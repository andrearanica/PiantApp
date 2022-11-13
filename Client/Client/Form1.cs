using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client {
    public partial class Form1 : Form {
        Account account;
        public Form1() {
            InitializeComponent();
            account = new Account();
        }

        private void pic_profile_Click (object sender, EventArgs e) {
            if (account.name == "undefined") {
                Login login = new Login(ref account);
                login.ShowDialog();
                if (account.name != "undefined") {
                    lbl_name.Text = account.name;
                    pnl_header.Visible = false;
                }
            } else {
                Info info = new Info(account);
                info.ShowDialog();
            }
        }

        private void btn_signup_Click(object sender, EventArgs e) {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
        private void createTitle (string title) {
            Label lbl_title = new Label();
            lbl_title.Visible = true;
            lbl_title.Text = title;
            Font font = new Font("Century Gothic", 20);
            lbl_title.Font = font;
            lbl_title.Location = new System.Drawing.Point(113, 60);
            lbl_title.Size = new System.Drawing.Size(140, 30);
            Controls.Add(lbl_title);
        }
        private void createNickname (string nickname) {
            Label lbl_nickname = new Label();
            lbl_nickname.Visible = true;
            lbl_nickname.Text = $"Post di { nickname }";
            Font font = new Font("Century Gothic", 14);
            lbl_nickname.Font = font;
            lbl_nickname.Location = new System.Drawing.Point(113, 100);
            lbl_nickname.Size = new System.Drawing.Size(140, 140);
            Controls.Add(lbl_nickname);
        }
        private void createPost (UserPost post) {
            createTitle(post.title);
            createNickname(post.author);
        }
        private UserPost getPost () {
            UserPost post = new UserPost();
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"post$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "") {
                        // response: title nickame
                        string[] data = response.Split(' ');
                        post.title = data[0];
                        post.author = data[1];
                        this.Close();
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

            return post;
        }
        private void btn_newPost_Click(object sender, EventArgs e) {
            UserPost post = getPost();
        }
    }
    public class Account {
        public string name { get; set; }
        public string surname { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Account () {
            this.name = this.surname = this.nickname = this.email = this.password = "undefined";
        }
        public Account (string name, string surname, string nickname, string email, string password) {
            this.name = name; this.surname = surname; this.nickname = nickname; this.email = email; this.password = password;
        }
    }
    public class UserPost {
        public string title { get; set; }
        public string author { get; set; }
        public UserPost () {

        }
        public UserPost (string title, string author) {
            this.title = title; this.author = author;
        }
    }
}
