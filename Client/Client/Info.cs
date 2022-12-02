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
                    byte[] msg = Encoding.ASCII.GetBytes($"addplant { account.nickname } { txt_plant.Text }$");
                    int bytestSent = sender.Send(msg);
                    string response = "";
                    while (response.IndexOf('$') == -1) {
                        int bytesRec = sender.Receive(bytes);
                        response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    }
                    if (response != "successfull$") { MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    byte[] msg = Encoding.ASCII.GetBytes($"plants { account.nickname }$");
                    int bytestSent = sender.Send(msg);
                    string response = "";
                    while (response.IndexOf('$') == -1) {
                        int bytesRec = sender.Receive(bytes);
                        response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    }
                    string[] plants = response.Split(' ');
                    foreach (string plant in plants) {
                        if (plant != "" && plant != "$") list_plants.Items.Add(plant);
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

        private void removePlant (string plant) {
            byte[] bytes = new byte[1024];
            try {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remote = new IPEndPoint(ipAddress, 5000);
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try {
                    sender.Connect(remote);
                    byte[] msg = Encoding.ASCII.GetBytes($"removeplant { account.nickname } { plant }$");
                    int bytestSent = sender.Send(msg);
                    int bytesRec = sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (response == "successfull$") { MessageBox.Show("Impostazioni aggiornate correttamente, riavvia l'applicazione per vedere le modifiche"); }
                    else { MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                } catch (Exception) {
                    MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception) {
                MessageBox.Show("C'è stato un errore, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (list_plants.Items.Count < 10) {
                if (list_plants.Items.IndexOf(txt_plant.Text) == -1) {
                    addPlant();
                    list_plants.Items.Clear();
                    getPlants();
                } else {
                    MessageBox.Show("Hai già inserito questa pianta", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else {
                MessageBox.Show("Puoi inserire solamente 10 piante, rimuovi quelle vecchie per inserirne una nuova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_update_Click(object sender, EventArgs e) {
            if (txt_email.Text.IndexOf('@') != -1 && txt_email.Text.IndexOf('.') != -1) {
                updateInfo();
            } else {
                MessageBox.Show("Formato della mail non corretto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
