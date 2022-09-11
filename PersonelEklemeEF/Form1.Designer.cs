namespace PersonelEklemeEF.UI
{
    partial class Form1
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
            this.btnIletisimBilgileri = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBirimler = new System.Windows.Forms.ComboBox();
            this.rdoKadin = new System.Windows.Forms.RadioButton();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPersonelDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPersonelTCNo = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpPersonelEkle = new System.Windows.Forms.GroupBox();
            this.grpPersonelEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIletisimBilgileri
            // 
            this.btnIletisimBilgileri.Location = new System.Drawing.Point(31, 301);
            this.btnIletisimBilgileri.Name = "btnIletisimBilgileri";
            this.btnIletisimBilgileri.Size = new System.Drawing.Size(321, 33);
            this.btnIletisimBilgileri.TabIndex = 7;
            this.btnIletisimBilgileri.Text = "İLETİŞİM BİLGİLERİNİ GİR";
            this.btnIletisimBilgileri.UseVisualStyleBackColor = true;
            this.btnIletisimBilgileri.Click += new System.EventHandler(this.btnIletisimBilgileri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birim:";
            // 
            // cmbBirimler
            // 
            this.cmbBirimler.FormattingEnabled = true;
            this.cmbBirimler.Items.AddRange(new object[] {
            "Yazılım",
            "Muhasebe",
            "İngilizce",
            "Sosyal Medya Uzmanı",
            "Grafik Tasarım",
            "3D Çizim"});
            this.cmbBirimler.Location = new System.Drawing.Point(111, 162);
            this.cmbBirimler.Name = "cmbBirimler";
            this.cmbBirimler.Size = new System.Drawing.Size(192, 21);
            this.cmbBirimler.TabIndex = 11;
            // 
            // rdoKadin
            // 
            this.rdoKadin.AutoSize = true;
            this.rdoKadin.Location = new System.Drawing.Point(218, 138);
            this.rdoKadin.Name = "rdoKadin";
            this.rdoKadin.Size = new System.Drawing.Size(52, 17);
            this.rdoKadin.TabIndex = 10;
            this.rdoKadin.TabStop = true;
            this.rdoKadin.Text = "Kadın";
            this.rdoKadin.UseVisualStyleBackColor = true;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(111, 138);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(53, 17);
            this.rdoErkek.TabIndex = 9;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cinsiyet:";
            // 
            // dtPersonelDogumTarihi
            // 
            this.dtPersonelDogumTarihi.Location = new System.Drawing.Point(111, 102);
            this.dtPersonelDogumTarihi.Name = "dtPersonelDogumTarihi";
            this.dtPersonelDogumTarihi.Size = new System.Drawing.Size(192, 20);
            this.dtPersonelDogumTarihi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(31, 248);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 33);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPersonelTCNo
            // 
            this.txtPersonelTCNo.Location = new System.Drawing.Point(111, 79);
            this.txtPersonelTCNo.Name = "txtPersonelTCNo";
            this.txtPersonelTCNo.Size = new System.Drawing.Size(192, 20);
            this.txtPersonelTCNo.TabIndex = 5;
            // 
            // txtPersonelSoyadi
            // 
            this.txtPersonelSoyadi.Location = new System.Drawing.Point(111, 53);
            this.txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            this.txtPersonelSoyadi.Size = new System.Drawing.Size(192, 20);
            this.txtPersonelSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(111, 27);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(192, 20);
            this.txtPersonelAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(202, 248);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 33);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // grpPersonelEkle
            // 
            this.grpPersonelEkle.Controls.Add(this.label6);
            this.grpPersonelEkle.Controls.Add(this.cmbBirimler);
            this.grpPersonelEkle.Controls.Add(this.rdoKadin);
            this.grpPersonelEkle.Controls.Add(this.rdoErkek);
            this.grpPersonelEkle.Controls.Add(this.label5);
            this.grpPersonelEkle.Controls.Add(this.dtPersonelDogumTarihi);
            this.grpPersonelEkle.Controls.Add(this.label4);
            this.grpPersonelEkle.Controls.Add(this.txtPersonelTCNo);
            this.grpPersonelEkle.Controls.Add(this.label3);
            this.grpPersonelEkle.Controls.Add(this.txtPersonelSoyadi);
            this.grpPersonelEkle.Controls.Add(this.label2);
            this.grpPersonelEkle.Controls.Add(this.txtPersonelAdi);
            this.grpPersonelEkle.Controls.Add(this.label1);
            this.grpPersonelEkle.Location = new System.Drawing.Point(31, 23);
            this.grpPersonelEkle.Name = "grpPersonelEkle";
            this.grpPersonelEkle.Size = new System.Drawing.Size(321, 217);
            this.grpPersonelEkle.TabIndex = 4;
            this.grpPersonelEkle.TabStop = false;
            this.grpPersonelEkle.Text = "Personel Kayıt Ekranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 363);
            this.Controls.Add(this.btnIletisimBilgileri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.grpPersonelEkle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonelEkle.ResumeLayout(false);
            this.grpPersonelEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIletisimBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBirimler;
        private System.Windows.Forms.RadioButton rdoKadin;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPersonelDogumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPersonelTCNo;
        private System.Windows.Forms.TextBox txtPersonelSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPersonelEkle;
    }
}

