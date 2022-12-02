
namespace Client
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_plant = new System.Windows.Forms.TextBox();
            this.lbl_ask = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_pl = new System.Windows.Forms.Label();
            this.list_plants = new System.Windows.Forms.ListBox();
            this.btn_removePlant = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_account = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il tuo account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 78);
            this.panel1.TabIndex = 1;
            // 
            // txt_plant
            // 
            this.txt_plant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_plant.Location = new System.Drawing.Point(241, 322);
            this.txt_plant.Name = "txt_plant";
            this.txt_plant.Size = new System.Drawing.Size(211, 26);
            this.txt_plant.TabIndex = 3;
            // 
            // lbl_ask
            // 
            this.lbl_ask.AutoSize = true;
            this.lbl_ask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ask.Location = new System.Drawing.Point(241, 298);
            this.lbl_ask.Name = "lbl_ask";
            this.lbl_ask.Size = new System.Drawing.Size(201, 20);
            this.lbl_ask.TabIndex = 4;
            this.lbl_ask.Text = "Inserisci una nuova pianta";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(241, 350);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 32);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Aggiungi";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_pl
            // 
            this.lbl_pl.AutoSize = true;
            this.lbl_pl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pl.Location = new System.Drawing.Point(12, 270);
            this.lbl_pl.Name = "lbl_pl";
            this.lbl_pl.Size = new System.Drawing.Size(143, 25);
            this.lbl_pl.TabIndex = 6;
            this.lbl_pl.Text = "Le tue piante";
            // 
            // list_plants
            // 
            this.list_plants.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_plants.FormattingEnabled = true;
            this.list_plants.ItemHeight = 20;
            this.list_plants.Location = new System.Drawing.Point(12, 298);
            this.list_plants.Name = "list_plants";
            this.list_plants.Size = new System.Drawing.Size(211, 124);
            this.list_plants.TabIndex = 7;
            // 
            // btn_removePlant
            // 
            this.btn_removePlant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_removePlant.Location = new System.Drawing.Point(241, 388);
            this.btn_removePlant.Name = "btn_removePlant";
            this.btn_removePlant.Size = new System.Drawing.Size(211, 27);
            this.btn_removePlant.TabIndex = 8;
            this.btn_removePlant.Text = "Rimuovi pianta";
            this.btn_removePlant.UseVisualStyleBackColor = true;
            this.btn_removePlant.Click += new System.EventHandler(this.btn_removePlant_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(115, 134);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(337, 26);
            this.txt_name.TabIndex = 9;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_surname.Location = new System.Drawing.Point(115, 166);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(337, 26);
            this.txt_surname.TabIndex = 10;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(115, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(337, 26);
            this.txt_email.TabIndex = 11;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_account.Location = new System.Drawing.Point(12, 103);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(106, 25);
            this.lbl_account.TabIndex = 13;
            this.lbl_account.Text = "I tuoi dati";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.Location = new System.Drawing.Point(199, 230);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(253, 32);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Aggiorna";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(12, 169);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(83, 20);
            this.lbl_surname.TabIndex = 15;
            this.lbl_surname.Text = "Cognome";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(12, 137);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 20);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Nome";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mail.Location = new System.Drawing.Point(12, 201);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(46, 20);
            this.lbl_mail.TabIndex = 17;
            this.lbl_mail.Text = "Email";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 458);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_removePlant);
            this.Controls.Add(this.list_plants);
            this.Controls.Add(this.lbl_pl);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_ask);
            this.Controls.Add(this.txt_plant);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_plant;
        private System.Windows.Forms.Label lbl_ask;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_pl;
        private System.Windows.Forms.ListBox list_plants;
        private System.Windows.Forms.Button btn_removePlant;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_mail;
    }
}