using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client {
    public partial class Info : Form {
        Account account;
        public Info(Account account) {
            InitializeComponent();
            this.account = account;
        }

        private void Info_Load(object sender, EventArgs e) {
            lbl_info.Text = $"Nome: { account.name } | Cognome: { account.surname } | Nickname: { account.nickname }\nEmail: { account.email } | Password: { account.password }";
        }
    }
}
