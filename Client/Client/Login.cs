using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;

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

        string hash(string password) {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }

        private void connect () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"login { txt_username.Text } { hash(txt_password.Text) }$");
                    int bytestSent = sender.Send(msg);
                    string response = "";
                    while (response.IndexOf('$') == -1) {
                        int bytesRec = sender.Receive(bytes);
                        response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    }
                    if (response != "$") {
                        // response: surname + name + nickname + email + password
                        string[] data = response.Split(' ');
                        account.surname = data[0];
                        account.name = data[1];
                        account.nickname = data[2];
                        account.email = data[3];
                        account.password = data[4];
                        account.image = data[5];
                        account.likes = int.Parse(data[6]);
                        account.liked = int.Parse(data[7].Split('$')[0]);
                        this.Close();
                    } else {
                        lbl_error.Visible = true;
                    }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
