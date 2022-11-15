using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

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
            if (status) lbl_status.Text = "Il server è acceso";
            else lbl_status.Text = "Il server è spento";
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
        private List<Account> readJSON () {
            string json = System.IO.File.ReadAllText(@"..\..\..\json\accounts.json");
            return JsonSerializer.Deserialize<List<Account>>(json);
        }
        private bool login (string username, string password, ref Account result) {
            foreach (Account account in readJSON()) {
                if (account.nickname == username && account.password == password) {
                    result = account;
                    return true;
                }
            }
            return false;
        }
        private void writeNewAccount (Account account) {
            string json = System.IO.File.ReadAllText(@"..\..\..\json\accounts.json");
            List<Account> accounts = JsonSerializer.Deserialize<List<Account>>(json);
            accounts.Add(account);
            json = JsonSerializer.Serialize(accounts);
            System.IO.File.WriteAllText(@"..\..\..\json\accounts.json", json);
        }
        private void login (string data, ref Socket handler) {
            string info = data.Substring(6);
            string[] loginInfo = info.Split(' ');
            Account result = new Account();
            if (login(loginInfo[0], loginInfo[1].Remove(loginInfo[1].Length - 1, 1), ref result)) {
                handler.Send(Encoding.ASCII.GetBytes($"{ result.surname } { result.name } { result.nickname } { result.email } { result.password }"));
            } else {
                handler.Send(Encoding.ASCII.GetBytes(""));
            }
        }
        private void register (string data, ref Socket handler) {
            string info = data.Substring(9);
            string[] signupInfo = info.Split(' ');
            Account newAccount = new Account();
            newAccount.surname = signupInfo[0];
            newAccount.name = signupInfo[1];
            newAccount.nickname = signupInfo[2];
            newAccount.email = signupInfo[3];
            newAccount.password = signupInfo[4].Remove(signupInfo[4].Length - 1, 1);

            bool valid = true;

            foreach (Account account in readJSON()) {
                if (account.nickname == newAccount.nickname || account.email == newAccount.email) {
                    valid = false;
                }
            }
                
            if (valid) {
                writeNewAccount(newAccount);
                handler.Send(Encoding.ASCII.GetBytes("successfull"));
            } else {
                handler.Send(Encoding.ASCII.GetBytes(""));
            }
        }
        private void post (string data, ref Socket handler) {
            UserPost post = new UserPost();
            string json = System.IO.File.ReadAllText(@"..\..\..\json\posts.json");
            List<UserPost> posts = JsonSerializer.Deserialize<List<UserPost>>(json);

            post = posts[new Random().Next(0, posts.Count)];

            handler.Send(Encoding.ASCII.GetBytes($"{ post.title } { post.author } { post.date } #{ post.description }"));
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

                    if (data[0] == 'l') {                           // If the user sends login
                        login(data, ref handler);
                    }
                    else if (data[0] == 'r') {                      // If the user sends registration
                        register(data, ref handler);
                    } else if (data[0] == 'p') {                    // If the user sends post
                        post(data, ref handler);
                    } else {
                        handler.Send(Encoding.ASCII.GetBytes(""));
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
        public string date { get; set; }
        public string description { get; set; }
        public UserPost() {

        }
        public UserPost(string title, string author, string date, string description) {
            this.title = title; this.author = author; this.date = date; this.description = description;
        }
    }
}
