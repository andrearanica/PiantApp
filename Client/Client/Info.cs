using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client {
    public partial class Info : Form {
        Account account;
        public Info(Account account) {
            InitializeComponent();
            this.account = account;
        }

        private void Info_Load(object sender, EventArgs e) {
            txt_name.Text = account.name;
            txt_surname.Text = account.surname;
            txt_email.Text = account.email;
            getPlants();
        }

        private void addPlant () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"Addplant { account.nickname } { txt_plant.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response != "") {
                        
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

        private void getPlants() {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"Plants { account.nickname }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    string[] plants = response.Split(' ');
                    foreach (string plant in plants) {
                        if (plant != "") list_plants.Items.Add(plant);
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

        private void removePlant (string plant) {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"Removeplant { account.nickname } { plant }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova");
                }
            }
            catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }

        private void updateInfo () {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"update { account.nickname } { txt_name.Text } { txt_surname.Text } { txt_email.Text }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (response == "successfull") { MessageBox.Show("Impostazioni aggiornate correttamente"); }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova");
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova");
            }
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (list_plants.Items.Count < 10) {
                addPlant();
                list_plants.Items.Clear();
                getPlants();
            } else {
                MessageBox.Show("Puoi inserire solamente 10 piante, rimuovi quelle vecchie per inserirne una nuova");
            }
            
        }

        private void btn_removePlant_Click(object sender, EventArgs e) {
            if (list_plants.SelectedIndex != -1) {
                removePlant(list_plants.SelectedItem.ToString());
                list_plants.Items.Clear();
                getPlants();
            } else {
                MessageBox.Show("Seleziona la pianta da rimuovere");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateInfo();
        }
    }
}
