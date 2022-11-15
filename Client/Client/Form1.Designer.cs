
namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addPost = new System.Windows.Forms.Button();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_newPost = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_addPost);
            this.panel1.Controls.Add(this.pic_profile);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 585);
            this.panel1.TabIndex = 0;
            // 
            // btn_addPost
            // 
            this.btn_addPost.Location = new System.Drawing.Point(31, 157);
            this.btn_addPost.Name = "btn_addPost";
            this.btn_addPost.Size = new System.Drawing.Size(40, 37);
            this.btn_addPost.TabIndex = 1;
            this.btn_addPost.Text = "+";
            this.btn_addPost.UseVisualStyleBackColor = true;
            this.btn_addPost.Visible = false;
            this.btn_addPost.Click += new System.EventHandler(this.btn_addPost_Click);
            // 
            // pic_profile
            // 
            this.pic_profile.Image = ((System.Drawing.Image)(resources.GetObject("pic_profile.Image")));
            this.pic_profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_profile.InitialImage")));
            this.pic_profile.Location = new System.Drawing.Point(11, 42);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(80, 80);
            this.pic_profile.TabIndex = 0;
            this.pic_profile.TabStop = false;
            this.pic_profile.Click += new System.EventHandler(this.pic_profile_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_name.Location = new System.Drawing.Point(11, 125);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 21);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Guest";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "PiantApp";
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.Controls.Add(this.btn_signup);
            this.pnl_header.Controls.Add(this.label2);
            this.pnl_header.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_header.Location = new System.Drawing.Point(113, 60);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(879, 97);
            this.pnl_header.TabIndex = 2;
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signup.Location = new System.Drawing.Point(198, 52);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(86, 26);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "Registrati";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Per effettuare l\'accesso, clicca sull\'immagine profilo\r\n\r\nSe non hai un account, " +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 53);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_newPost
            // 
            this.btn_newPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newPost.Location = new System.Drawing.Point(893, 62);
            this.btn_newPost.Name = "btn_newPost";
            this.btn_newPost.Size = new System.Drawing.Size(96, 29);
            this.btn_newPost.TabIndex = 4;
            this.btn_newPost.Text = "Ricarica";
            this.btn_newPost.UseVisualStyleBackColor = true;
            this.btn_newPost.Visible = false;
            this.btn_newPost.Click += new System.EventHandler(this.btn_newPost_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(11, 540);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(80, 30);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Esci";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.btn_newPost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1020, 620);
            this.Name = "Form1";
            this.Text = "PiantApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_profile;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newPost;
        private System.Windows.Forms.Button btn_addPost;
        private System.Windows.Forms.Button btn_logout;
    }
}

