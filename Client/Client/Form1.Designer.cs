
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
            this.lbl_countLiked = new System.Windows.Forms.Label();
            this.pic_liked = new System.Windows.Forms.PictureBox();
            this.pic_addPost = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_addPost = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_newPost = new System.Windows.Forms.Button();
            this.btn_lik = new System.Windows.Forms.Button();
            this.pic_plant = new System.Windows.Forms.PictureBox();
            this.pic_plan = new System.Windows.Forms.PictureBox();
            this.btn_like = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_like)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lbl_countLiked);
            this.panel1.Controls.Add(this.pic_liked);
            this.panel1.Controls.Add(this.pic_addPost);
            this.panel1.Controls.Add(this.pic_search);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pic_profile);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 624);
            this.panel1.TabIndex = 0;
            // 
            // lbl_countLiked
            // 
            this.lbl_countLiked.AutoSize = true;
            this.lbl_countLiked.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_countLiked.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_countLiked.Location = new System.Drawing.Point(42, 216);
            this.lbl_countLiked.Name = "lbl_countLiked";
            this.lbl_countLiked.Size = new System.Drawing.Size(0, 19);
            this.lbl_countLiked.TabIndex = 7;
            // 
            // pic_liked
            // 
            this.pic_liked.Image = ((System.Drawing.Image)(resources.GetObject("pic_liked.Image")));
            this.pic_liked.Location = new System.Drawing.Point(28, 166);
            this.pic_liked.Name = "pic_liked";
            this.pic_liked.Size = new System.Drawing.Size(44, 44);
            this.pic_liked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_liked.TabIndex = 6;
            this.pic_liked.TabStop = false;
            this.pic_liked.Visible = false;
            // 
            // pic_addPost
            // 
            this.pic_addPost.Image = ((System.Drawing.Image)(resources.GetObject("pic_addPost.Image")));
            this.pic_addPost.Location = new System.Drawing.Point(24, 268);
            this.pic_addPost.Name = "pic_addPost";
            this.pic_addPost.Size = new System.Drawing.Size(55, 55);
            this.pic_addPost.TabIndex = 5;
            this.pic_addPost.TabStop = false;
            this.pic_addPost.Visible = false;
            this.pic_addPost.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_search
            // 
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(24, 329);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(55, 55);
            this.pic_search.TabIndex = 3;
            this.pic_search.TabStop = false;
            this.pic_search.Visible = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.Location = new System.Drawing.Point(12, 579);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(80, 30);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Esci";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pic_profile
            // 
            this.pic_profile.Image = ((System.Drawing.Image)(resources.GetObject("pic_profile.Image")));
            this.pic_profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_profile.InitialImage")));
            this.pic_profile.Location = new System.Drawing.Point(11, 42);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(80, 80);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // btn_addPost
            // 
            this.btn_addPost.Location = new System.Drawing.Point(949, 536);
            this.btn_addPost.Name = "btn_addPost";
            this.btn_addPost.Size = new System.Drawing.Size(40, 37);
            this.btn_addPost.TabIndex = 1;
            this.btn_addPost.Text = "+";
            this.btn_addPost.UseVisualStyleBackColor = true;
            this.btn_addPost.Visible = false;
            this.btn_addPost.Click += new System.EventHandler(this.btn_addPost_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(129, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(368, 38);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Benvenuto in PiantApp";
            // 
            // pnl_header
            // 
            this.pnl_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_header.Controls.Add(this.btn_signup);
            this.pnl_header.Controls.Add(this.lbl_desc);
            this.pnl_header.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_header.Location = new System.Drawing.Point(129, 75);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(478, 101);
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
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(3, 12);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(470, 63);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "Per effettuare l\'accesso clicca sull\'immagine profilo a sinistra\r\n\r\nSe non hai un" +
    " account, ";
            // 
            // pic_next
            // 
            this.pic_next.Image = ((System.Drawing.Image)(resources.GetObject("pic_next.Image")));
            this.pic_next.Location = new System.Drawing.Point(191, 243);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(56, 55);
            this.pic_next.TabIndex = 2;
            this.pic_next.TabStop = false;
            this.pic_next.Visible = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 53);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_newPost
            // 
            this.btn_newPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newPost.Location = new System.Drawing.Point(730, 62);
            this.btn_newPost.Name = "btn_newPost";
            this.btn_newPost.Size = new System.Drawing.Size(96, 29);
            this.btn_newPost.TabIndex = 4;
            this.btn_newPost.Text = "Ricarica";
            this.btn_newPost.UseVisualStyleBackColor = true;
            this.btn_newPost.Visible = false;
            this.btn_newPost.Click += new System.EventHandler(this.btn_newPost_Click);
            // 
            // btn_lik
            // 
            this.btn_lik.Location = new System.Drawing.Point(581, 573);
            this.btn_lik.Name = "btn_lik";
            this.btn_lik.Size = new System.Drawing.Size(76, 40);
            this.btn_lik.TabIndex = 5;
            this.btn_lik.Text = "<3";
            this.btn_lik.UseVisualStyleBackColor = true;
            this.btn_lik.Visible = false;
            this.btn_lik.Click += new System.EventHandler(this.btn_like_Click);
            // 
            // pic_plant
            // 
            this.pic_plant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_plant.Image = ((System.Drawing.Image)(resources.GetObject("pic_plant.Image")));
            this.pic_plant.Location = new System.Drawing.Point(462, -15);
            this.pic_plant.Name = "pic_plant";
            this.pic_plant.Size = new System.Drawing.Size(378, 281);
            this.pic_plant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_plant.TabIndex = 6;
            this.pic_plant.TabStop = false;
            // 
            // pic_plan
            // 
            this.pic_plan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_plan.Image = ((System.Drawing.Image)(resources.GetObject("pic_plan.Image")));
            this.pic_plan.Location = new System.Drawing.Point(663, 453);
            this.pic_plan.Name = "pic_plan";
            this.pic_plan.Size = new System.Drawing.Size(177, 170);
            this.pic_plan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_plan.TabIndex = 12;
            this.pic_plan.TabStop = false;
            // 
            // btn_like
            // 
            this.btn_like.Image = ((System.Drawing.Image)(resources.GetObject("btn_like.Image")));
            this.btn_like.Location = new System.Drawing.Point(129, 243);
            this.btn_like.Name = "btn_like";
            this.btn_like.Size = new System.Drawing.Size(56, 55);
            this.btn_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_like.TabIndex = 13;
            this.btn_like.TabStop = false;
            this.btn_like.Visible = false;
            this.btn_like.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 620);
            this.Controls.Add(this.btn_like);
            this.Controls.Add(this.pic_plan);
            this.Controls.Add(this.btn_lik);
            this.Controls.Add(this.pic_next);
            this.Controls.Add(this.btn_newPost);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_addPost);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_plant);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(857, 659);
            this.Name = "Form1";
            this.Text = " PiantApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_like)).EndInit();
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
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newPost;
        private System.Windows.Forms.Button btn_addPost;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.PictureBox pic_addPost;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_liked;
        private System.Windows.Forms.Label lbl_countLiked;
        private System.Windows.Forms.Button btn_lik;
        private System.Windows.Forms.PictureBox pic_plant;
        private System.Windows.Forms.PictureBox pic_plan;
        private System.Windows.Forms.PictureBox btn_like;
    }
}

