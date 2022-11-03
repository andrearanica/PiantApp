using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Server {
    public partial class Form1 : Form {
        Server server;
        public Form1 () {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            server = new Server(list_update);
        }

        private void btn_start_Click (object sender, EventArgs e) {
            if (server.status == false) server.On();
            else { server.Off(); this.Close(); }
            updateStatus(server.status);
        }

        private void updateStatus (bool status) {
            if (status) lbl_status.Text = "Il tuo server è acceso";
            else lbl_status.Text = "Il tuo server è spento";
        }
    }

    public class Server {
        public bool status { get; set; }    // Server status (true - false)
        public string data { get; set; }    // Message from the client
        public string ip { get; set; }      // IP server (127.0.0.1)
        public int port { get; set; }       // PORT server
        public ListBox listbox { get; set; }      // Form for updating 
        
        public Server (ListBox listbox) {
            status = false; data = null; ip = "127.0.0.1"; port = 5000; this.listbox = listbox;
        }
        public void On () {
            status = true;
            Thread d = new Thread(new ThreadStart(startListening));
            d.Start();
        }
        public void Off () {
            status = false;
        }
        private bool login (string username, string password) {
            if (username == "andre" && password == "bicigialla") {
                return true;
            } else {
                return false;
            }
        }
        public void startListening () {     // Server starts listening for clients
            byte[] bytes = new byte[1024];
            IPAddress ipAddress = System.Net.IPAddress.Parse(this.ip);
            IPEndPoint local = new IPEndPoint(ipAddress, port);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try {
                listener.Bind(local);
                listener.Listen(10);
                while (true) {
                    listbox.Items.Add("Aspetto una connessione...");
                    Socket handler = listener.Accept();
                    data = null;
                    while (true) {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("$") > -1) {
                            break;
                        }
                    }
                    listbox.Items.Add($"Testo ricevuto: { data }");
                    // Check
                    if (data[0] == 'l') {
                        string info = data.Substring(6);
                        string[] loginInfo = info.Split(' '); 
                        if (login(loginInfo[0], loginInfo[1].Remove(loginInfo[1].Length - 1, 1))) {
                            handler.Send(Encoding.ASCII.GetBytes("Login effettuato"));
                        } else {
                            handler.Send(Encoding.ASCII.GetBytes("Login errato"));
                        }
                    } else {
                        handler.Send(Encoding.ASCII.GetBytes("N'hoccapito"));
                    }
                    listbox.Items.Add(data);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            } catch (Exception e) {
                listbox.Items.Add($"Errore: { e.ToString() }");
            }
        }
    }
}
