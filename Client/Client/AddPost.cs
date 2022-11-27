using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client {
    public partial class AddPost : Form {
        string nickname;
        public AddPost (string nickname) {
            InitializeComponent();
            this.nickname = nickname;
            txt_data.Text = $"{ DateTime.Now.Day }/{ DateTime.Now.Month }/{ DateTime.Now.Year }";
            // DataGridViewColumnEventArgs
            txt_author.Text = nickname;
        }

        private void connect () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"add { txt_title.Text } { txt_author.Text } { txt_data.Text } { txt_description.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "successfull") {
                        MessageBox.Show("E' già presente un post con questo titolo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova");
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova");
            }
            this.Close();
        }

        private bool checkData (string title, string author, string date, string description) {
            if (title != "" && author != "" && date != "" && description != "") {
                int n = 0;
                foreach (char a in date) {
                    if (a == '/') n++;
                }
                if (n > 1) return true;
                else return false;
            } else {
                return false;
            }
        }

        private void replace () {
            txt_description.Text = txt_description.Text.Replace(' ', '-');
            txt_title.Text = txt_title.Text.Replace(' ', '-');
            txt_data.Text = txt_data.Text.Replace(' ', '-');
            txt_author.Text = txt_author.Text.Replace(' ', '-');
        }

        private void btn_send_Click(object sender, EventArgs e) {
            replace();

            if (checkData(txt_title.Text, txt_author.Text, txt_data.Text, txt_description.Text)) {
                connect();
            } else {
                MessageBox.Show("Dati inseriti non correttamente");
            }
        }

        private void AddPost_Load(object sender, EventArgs e)
        {

        }
    }
}
