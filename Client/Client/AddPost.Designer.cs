
namespace Client
{
    partial class AddPost
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lbl_1);
            this.panel1.Location = new System.Drawing.Point(-498, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 61);
            this.panel1.TabIndex = 0;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_1.Location = new System.Drawing.Point(568, 10);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(162, 32);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Nuovo post";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(136, 69);
            this.txt_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(144, 26);
            this.txt_title.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 75);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(45, 20);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Titolo";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(12, 179);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(92, 20);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Descrizione";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_send.Location = new System.Drawing.Point(64, 215);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(171, 46);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Posta";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(12, 111);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(59, 20);
            this.lbl_author.TabIndex = 7;
            this.lbl_author.Text = "Autore";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(136, 106);
            this.txt_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_author.Name = "txt_author";
            this.txt_author.ReadOnly = true;
            this.txt_author.Size = new System.Drawing.Size(144, 26);
            this.txt_author.TabIndex = 2;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(12, 145);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(45, 20);
            this.lbl_data.TabIndex = 9;
            this.lbl_data.Text = "Data";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(136, 139);
            this.txt_data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data.Name = "txt_data";
            this.txt_data.ReadOnly = true;
            this.txt_data.Size = new System.Drawing.Size(144, 26);
            this.txt_data.TabIndex = 3;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(136, 173);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(144, 26);
            this.txt_description.TabIndex = 4;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 273);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_description;
    }
}