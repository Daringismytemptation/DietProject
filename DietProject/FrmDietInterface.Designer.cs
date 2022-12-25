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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInterface));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.txtExtraCalorie = new System.Windows.Forms.TextBox();
            this.txtFoodGram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.btnAdi = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnOgun = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFoodName = new System.Windows.Forms.ComboBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.btnHaftalikRapor = new System.Windows.Forms.Button();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            this.btnFoodCollection = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGoruntule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnGoruntule.Location = new System.Drawing.Point(166, 103);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(74, 29);
            this.btnGoruntule.TabIndex = 15;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen işlem yapacağınız günü seçiniz.\r\n";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(16, 43);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(211, 20);
            this.dtpTarih.TabIndex = 0;
            this.dtpTarih.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dgvReports);
            this.groupBox2.Controls.Add(this.txtExtraCalorie);
            this.groupBox2.Controls.Add(this.txtFoodGram);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvKullanici);
            this.groupBox2.Controls.Add(this.btnAdi);
            this.groupBox2.Controls.Add(this.btnKategori);
            this.groupBox2.Controls.Add(this.btnOgun);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbFoodName);
            this.groupBox2.Controls.Add(this.cmbKategoriler);
            this.groupBox2.Controls.Add(this.cmbOgunler);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 640);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programım";
            // 
            // dgvReports
            // 
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(350, 335);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(582, 299);
            this.dgvReports.TabIndex = 0;
            // 
            // txtExtraCalorie
            // 
            this.txtExtraCalorie.Location = new System.Drawing.Point(46, 235);
            this.txtExtraCalorie.Name = "txtExtraCalorie";
            this.txtExtraCalorie.Size = new System.Drawing.Size(119, 20);
            this.txtExtraCalorie.TabIndex = 21;
            this.txtExtraCalorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodGram_KeyPress);
            // 
            // txtFoodGram
            // 
            this.txtFoodGram.Location = new System.Drawing.Point(46, 198);
            this.txtFoodGram.Name = "txtFoodGram";
            this.txtFoodGram.Size = new System.Drawing.Size(119, 20);
            this.txtFoodGram.TabIndex = 21;
            this.txtFoodGram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodGram_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(176, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Extra Alınan \r\nKalori Miktarı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Location = new System.Drawing.Point(350, 19);
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanici.Size = new System.Drawing.Size(582, 300);
            this.dgvKullanici.TabIndex = 13;
            this.dgvKullanici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellClick);
            this.dgvKullanici.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellValueChanged);
            // 
            // btnAdi
            // 
            this.btnAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdi.Location = new System.Drawing.Point(278, 162);
            this.btnAdi.Name = "btnAdi";
            this.btnAdi.Size = new System.Drawing.Size(27, 20);
            this.btnAdi.TabIndex = 11;
            this.btnAdi.Text = "...\r\n";
            this.btnAdi.UseVisualStyleBackColor = true;
            // 
            // btnKategori
            // 
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.Location = new System.Drawing.Point(278, 133);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(27, 20);
            this.btnKategori.TabIndex = 10;
            this.btnKategori.Text = "...\r\n";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnOgun
            // 
            this.btnOgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgun.Location = new System.Drawing.Point(278, 104);
            this.btnOgun.Name = "btnOgun";
            this.btnOgun.Size = new System.Drawing.Size(27, 20);
            this.btnOgun.TabIndex = 4;
            this.btnOgun.Text = "...\r\n";
            this.btnOgun.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(241, 553);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 47);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(129, 553);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 47);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(27, 553);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 47);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Location = new System.Drawing.Point(176, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yemek Gramajı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(176, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yemek Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(176, 136);
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
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(176, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğün";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFoodName
            // 
            this.cmbFoodName.FormattingEnabled = true;
            this.cmbFoodName.Location = new System.Drawing.Point(46, 166);
            this.cmbFoodName.Name = "cmbFoodName";
            this.cmbFoodName.Size = new System.Drawing.Size(121, 21);
            this.cmbFoodName.TabIndex = 2;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(46, 133);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriler.TabIndex = 1;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Location = new System.Drawing.Point(46, 101);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunler.TabIndex = 0;
            // 
            // btnHaftalikRapor
            // 
            this.btnHaftalikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnHaftalikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaftalikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaftalikRapor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHaftalikRapor.Location = new System.Drawing.Point(12, 466);
            this.btnHaftalikRapor.Name = "btnHaftalikRapor";
            this.btnHaftalikRapor.Size = new System.Drawing.Size(104, 63);
            this.btnHaftalikRapor.TabIndex = 4;
            this.btnHaftalikRapor.Text = "Haftalık Rapor\r\n";
            this.btnHaftalikRapor.UseVisualStyleBackColor = false;
            this.btnHaftalikRapor.Click += new System.EventHandler(this.btnHaftalikRapor_Click);
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnAylikRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylikRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylikRapor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAylikRapor.Location = new System.Drawing.Point(162, 466);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(104, 63);
            this.btnAylikRapor.TabIndex = 5;
            this.btnAylikRapor.Text = "Aylık Rapor\r\n";
            this.btnAylikRapor.UseVisualStyleBackColor = false;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // btnFoodCollection
            // 
            this.btnFoodCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodCollection.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFoodCollection.Location = new System.Drawing.Point(162, 336);
            this.btnFoodCollection.Name = "btnFoodCollection";
            this.btnFoodCollection.Size = new System.Drawing.Size(104, 63);
            this.btnFoodCollection.TabIndex = 5;
            this.btnFoodCollection.Text = "Yemek Ceşidi Raporu";
            this.btnFoodCollection.UseVisualStyleBackColor = false;
            this.btnFoodCollection.Click += new System.EventHandler(this.btnFoodCollection_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.Transparent;
            this.btnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDailyReport.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDailyReport.Location = new System.Drawing.Point(12, 336);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(104, 63);
            this.btnDailyReport.TabIndex = 4;
            this.btnDailyReport.Text = "Günlük Rapor";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(12, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(377, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Haftalık ve Aylık Rapor Seçilen Tarihten  Geriye Olacak Şekilde Çalışmaktadır .";
            // 
            // FrmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1287, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAylikRapor);
            this.Controls.Add(this.btnHaftalikRapor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFoodCollection);
            this.Controls.Add(this.btnDailyReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.FrmInterface_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFoodName;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ComboBox cmbOgunler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAdi;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnOgun;
        private System.Windows.Forms.Button btnHaftalikRapor;
        private System.Windows.Forms.Button btnAylikRapor;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExtraCalorie;
        private System.Windows.Forms.TextBox txtFoodGram;
        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnFoodCollection;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Label label7;
    }
}