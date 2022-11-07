using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                lbl_name.Text = account.name;
                pnl_header.Visible = false;
            } else {
                Info info = new Info(account);
                info.ShowDialog();
            }
        }

        private void btn_signup_Click(object sender, EventArgs e) {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void getPosts () {

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
