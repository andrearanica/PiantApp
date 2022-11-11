using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client {
    public partial class Login : Form {
        Account account;
        public Login (ref Account account) {
            InitializeComponent();
            this.account = account;
        }

        private void btn_login_Click(object sender, EventArgs e) {
            connect();
        }

        private void connect () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"login { txt_username.Text } { txt_password.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "") {
                        // response: surname + name + nickname + email + password
                        string[] data = response.Split(' ');
                        account.surname = data[0];
                        account.name = data[1];
                        account.nickname = data[2];
                        account.email = data[3];
                        account.password = data[4];
                        this.Close();
                    } else {
                        lbl_error.Visible = true;
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova");
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }
    }
}
