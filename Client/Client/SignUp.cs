using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text.Json;
using System.Security.Cryptography;

namespace Client {
    public partial class SignUp : Form {
        Account newAccount;
        public SignUp() {
            InitializeComponent();
            newAccount = new Account();
        }

        void setNewAccount() {
            newAccount.name = txt_name.Text;
            newAccount.surname = txt_surname.Text;
            newAccount.nickname = txt_nickname.Text;
            newAccount.email = txt_email.Text;
            newAccount.password = txt_password.Text;
        }
        private bool validEmail (string email) {
            bool at = false, dot = false;
            foreach (char c in email) {
                if (c == '@') at = true;
                if (c == '.') dot = true;
            }
            if (at && dot) return true;
            else return false;
        }
        private bool validPassword (string password) {
            char[] specialChars = { '*', '|', '!', '@', '#', '<', '>' };
            foreach (char c in password) {
                foreach (char s in specialChars) {
                    if (c == s) return true;
                }
            }
            return false;
        }

        string hash(string password) {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }
        private void btn_register_Click(object sender, EventArgs e) {
            lbl_error.Visible = false;
            lbl_passwordError.Visible = false;
            if (txt_name.Text != "" && txt_surname.Text != "" && validEmail(txt_email.Text)) {
                if (validPassword(txt_password.Text)) {
                    setNewAccount();
                    connect();
                } else {
                    lbl_passwordError.Visible = true;
                }
            } else {
                lbl_error.Visible = true;
            }
        }

        private void connect() {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"register { newAccount.surname } { newAccount.name } { newAccount.nickname } { newAccount.email } { hash(newAccount.password) } { cmb_images.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    if (response != "") {
                        this.Close();
                    } else {
                        MessageBox.Show("Nome utente o email già usati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_Load(object sender, EventArgs e) {
            string json = System.IO.File.ReadAllText(@"..\..\..\img\images.json");
            foreach (string image in JsonSerializer.Deserialize<List<String>>(json)) {
                cmb_images.Items.Add(image);
            }
        }
    }
}
