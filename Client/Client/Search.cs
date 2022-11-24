using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.Encodings;
using System.Drawing;

namespace Client
{
    public partial class Search : Form
    {
        Account account = new Account("", "", "", "", "", "", 0, 0);
        public Search() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            connect();
            getPlants();
            if (account.image != "") {
                pic_profile.Image = new Bitmap($@"..\..\..\img\{ account.image }.jpg");
            } else {
                pic_profile.Image = null;
            }
        }

        private void getPlants() {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"Plants { txt_nickname.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "") {
                        lbl_result.Text += $"\nPiante: { response }";
                    } else {
                        account = new Account("", "", "", "", "", "", 0, 0);
                        lbl_result.Text = "";
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

        private void connect () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"user { txt_nickname.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "not found") {
                        string[] data = response.Split(' ');
                        account = new Account(data[1], data[0], data[2], data[3], data[4], data[5], int.Parse(data[6]), int.Parse(data[7]));
                        lbl_result.Text = $"Account trovato:\n{ account.name } { account.surname } | { account.nickname }\nLikes: { account.likes } | Like ricevuti: { account.liked }";
                        pic_profile.Image = new Bitmap(@$"..\..\..\img\{ account.image }.jpg");
                    } else {
                        account = new Account("", "", "", "", "", "", 0, 0);
                        lbl_result.Text = "";
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    //MessageBox.Show("C'è stato un errore, riprova");
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }
    }
}
