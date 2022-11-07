﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

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
        private void btn_register_Click(object sender, EventArgs e) {
            setNewAccount();
            connect();
        }

        private void connect() {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"register { newAccount.surname } { newAccount.name } { newAccount.nickname } { newAccount.email } { newAccount.password }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    if (response != "") {

                    } else {
                        lbl_error.Text = "Dati non validi";
                    }

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("C'è stato un errore, riprova");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }
    }
}
