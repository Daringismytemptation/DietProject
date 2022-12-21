namespace DietProject
{
    partial class FrmInterface
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPorsiyon = new System.Windows.Forms.ComboBox();
            this.cmbAdı = new System.Windows.Forms.ComboBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOneriler = new System.Windows.Forms.DataGridView();
            this.btnMenudeOlmayanOneriler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHaftalikRapor = new System.Windows.Forms.Button();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnKaydet.Location = new System.Drawing.Point(165, 93);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen işlem yapacağınız günü seçiniz.\r\n";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(16, 29);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(211, 20);
            this.dtpTarih.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKullanici);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbPorsiyon);
            this.groupBox2.Controls.Add(this.cmbAdı);
            this.groupBox2.Controls.Add(this.cmbKategoriler);
            this.groupBox2.Controls.Add(this.cmbOgunler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 640);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programım";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(23, 570);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 47);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Blue;
            this.btnEkle.Location = new System.Drawing.Point(23, 501);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 47);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnGuncelle.Location = new System.Drawing.Point(23, 437);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 47);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(175, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Porsiyon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(175, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(175, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(175, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğün";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPorsiyon
            // 
            this.cmbPorsiyon.FormattingEnabled = true;
            this.cmbPorsiyon.Location = new System.Drawing.Point(33, 223);
            this.cmbPorsiyon.Name = "cmbPorsiyon";
            this.cmbPorsiyon.Size = new System.Drawing.Size(121, 21);
            this.cmbPorsiyon.TabIndex = 3;
            // 
            // cmbAdı
            // 
            this.cmbAdı.FormattingEnabled = true;
            this.cmbAdı.Location = new System.Drawing.Point(33, 190);
            this.cmbAdı.Name = "cmbAdı";
            this.cmbAdı.Size = new System.Drawing.Size(121, 21);
            this.cmbAdı.TabIndex = 2;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(33, 157);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriler.TabIndex = 1;
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Location = new System.Drawing.Point(33, 124);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunler.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOneriler);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 230);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öneriler";
            // 
            // dgvOneriler
            // 
            this.dgvOneriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOneriler.Location = new System.Drawing.Point(13, 33);
            this.dgvOneriler.Name = "dgvOneriler";
            this.dgvOneriler.Size = new System.Drawing.Size(209, 176);
            this.dgvOneriler.TabIndex = 0;
            // 
            // btnMenudeOlmayanOneriler
            // 
            this.btnMenudeOlmayanOneriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenudeOlmayanOneriler.Location = new System.Drawing.Point(43, 432);
            this.btnMenudeOlmayanOneriler.Name = "btnMenudeOlmayanOneriler";
            this.btnMenudeOlmayanOneriler.Size = new System.Drawing.Size(179, 40);
            this.btnMenudeOlmayanOneriler.TabIndex = 3;
            this.btnMenudeOlmayanOneriler.Text = "Menüde Olmayan Öneriler";
            this.btnMenudeOlmayanOneriler.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(236, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "...\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(236, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "...\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(236, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 20);
            this.button3.TabIndex = 11;
            this.button3.Text = "...\r\n";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(236, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 20);
            this.button4.TabIndex = 12;
            this.button4.Text = "...\r\n";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnHaftalikRapor
            // 
            this.btnHaftalikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnHaftalikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaftalikRapor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHaftalikRapor.Location = new System.Drawing.Point(13, 589);
            this.btnHaftalikRapor.Name = "btnHaftalikRapor";
            this.btnHaftalikRapor.Size = new System.Drawing.Size(104, 63);
            this.btnHaftalikRapor.TabIndex = 4;
            this.btnHaftalikRapor.Text = "Haftalık Rapor\r\n";
            this.btnHaftalikRapor.UseVisualStyleBackColor = false;
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylikRapor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAylikRapor.Location = new System.Drawing.Point(158, 589);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(104, 63);
            this.btnAylikRapor.TabIndex = 5;
            this.btnAylikRapor.Text = "Aylık Rapor\r\n";
            this.btnAylikRapor.UseVisualStyleBackColor = true;
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Location = new System.Drawing.Point(300, 41);
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.Size = new System.Drawing.Size(592, 286);
            this.dgvKullanici.TabIndex = 13;
            // 
            // FrmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 681);
            this.Controls.Add(this.btnAylikRapor);
            this.Controls.Add(this.btnHaftalikRapor);
            this.Controls.Add(this.btnMenudeOlmayanOneriler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInterface";
            this.Text = "Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOneriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOneriler;
        private System.Windows.Forms.Button btnMenudeOlmayanOneriler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPorsiyon;
        private System.Windows.Forms.ComboBox cmbAdı;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ComboBox cmbOgunler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHaftalikRapor;
        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.DataGridView dgvKullanici;
    }
}