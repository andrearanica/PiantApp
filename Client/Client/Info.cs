using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.Encodings;

namespace Client {
    public partial class Info : Form {
        Account account;
        public Info(Account account) {
            InitializeComponent();
            this.account = account;
        }

        private void Info_Load(object sender, EventArgs e) {
            lbl_info.Text = $"Nome: { account.name }\nCognome: { account.surname }\nNickname: { account.nickname }\nEmail: { account.email }\nPassword: { account.password }";
        }

        private void connect ()
        {
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"Addplant { account.nickname } { txt_plant.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "") {
                        
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (Exception)
                {
                    //MessageBox.Show("C'è stato un errore, riprova");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }

        private void btn_add_Click(object sender, EventArgs e) {
            connect();
        }
    }
}
