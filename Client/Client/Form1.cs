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
        Client client;
        public Form1() {
            InitializeComponent();
            client = new Client();
        }

        private void pic_profile_Click (object sender, EventArgs e) {
            Login login = new Login();
            login.ShowDialog();
        }
    }
    public class Client {

    }
}
