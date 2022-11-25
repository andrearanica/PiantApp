
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_plant = new System.Windows.Forms.TextBox();
            this.lbl_ask = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list_plants = new System.Windows.Forms.ListBox();
            this.btn_removePlant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 19);
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
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(12, 106);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(73, 20);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Text = "Account";
            // 
            // txt_plant
            // 
            this.txt_plant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_plant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_plant.Location = new System.Drawing.Point(404, 298);
            this.txt_plant.Name = "txt_plant";
            this.txt_plant.Size = new System.Drawing.Size(211, 26);
            this.txt_plant.TabIndex = 3;
            // 
            // lbl_ask
            // 
            this.lbl_ask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ask.AutoSize = true;
            this.lbl_ask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ask.Location = new System.Drawing.Point(404, 274);
            this.lbl_ask.Name = "lbl_ask";
            this.lbl_ask.Size = new System.Drawing.Size(176, 20);
            this.lbl_ask.TabIndex = 4;
            this.lbl_ask.Text = "Hai una nuova pianta?";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(404, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 32);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Aggiungi";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(404, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Le tue piante";
            // 
            // list_plants
            // 
            this.list_plants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.list_plants.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_plants.FormattingEnabled = true;
            this.list_plants.ItemHeight = 20;
            this.list_plants.Location = new System.Drawing.Point(404, 131);
            this.list_plants.Name = "list_plants";
            this.list_plants.Size = new System.Drawing.Size(211, 124);
            this.list_plants.TabIndex = 7;
            // 
            // btn_removePlant
            // 
            this.btn_removePlant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_removePlant.Location = new System.Drawing.Point(404, 364);
            this.btn_removePlant.Name = "btn_removePlant";
            this.btn_removePlant.Size = new System.Drawing.Size(211, 27);
            this.btn_removePlant.TabIndex = 8;
            this.btn_removePlant.Text = "Rimuovi pianta";
            this.btn_removePlant.UseVisualStyleBackColor = true;
            this.btn_removePlant.Click += new System.EventHandler(this.btn_removePlant_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 425);
            this.Controls.Add(this.btn_removePlant);
            this.Controls.Add(this.list_plants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_ask);
            this.Controls.Add(this.txt_plant);
            this.Controls.Add(this.lbl_info);
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
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_plant;
        private System.Windows.Forms.Label lbl_ask;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_plants;
        private System.Windows.Forms.Button btn_removePlant;
    }
}