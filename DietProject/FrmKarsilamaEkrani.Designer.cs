namespace DietProject
{
    partial class FrmKarsilamaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKarsilamaEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(523, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz ";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblKullanici.Location = new System.Drawing.Point(610, 29);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(63, 15);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Kullanıcı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 117);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bilgilendirme";
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.Transparent;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaslat.Location = new System.Drawing.Point(27, 274);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(93, 25);
            this.btnBaslat.TabIndex = 14;
            this.btnBaslat.Text = "Başlayalım!";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Diyetine Başla";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(697, 314);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifre Değiştir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmKarsilamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 340);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKarsilamaEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KarsilamaEkrani";
            this.Load += new System.EventHandler(this.FrmKarsilamaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}