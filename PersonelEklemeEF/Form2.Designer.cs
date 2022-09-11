namespace PersonelEklemeEF.UI
{
    partial class Form2
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
            this.grpIletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEvAdresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirGuncelle = new System.Windows.Forms.Button();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTumKayitlar = new System.Windows.Forms.Button();
            this.btnYeniPersonel = new System.Windows.Forms.Button();
            this.grpIletisimBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIletisimBilgileri
            // 
            this.grpIletisimBilgileri.Controls.Add(this.btnKaydet);
            this.grpIletisimBilgileri.Controls.Add(this.label4);
            this.grpIletisimBilgileri.Controls.Add(this.txtEvAdresi);
            this.grpIletisimBilgileri.Controls.Add(this.label3);
            this.grpIletisimBilgileri.Controls.Add(this.txtTelefon);
            this.grpIletisimBilgileri.Controls.Add(this.txtEposta);
            this.grpIletisimBilgileri.Controls.Add(this.label2);
            this.grpIletisimBilgileri.Location = new System.Drawing.Point(32, 130);
            this.grpIletisimBilgileri.Name = "grpIletisimBilgileri";
            this.grpIletisimBilgileri.Size = new System.Drawing.Size(354, 299);
            this.grpIletisimBilgileri.TabIndex = 12;
            this.grpIletisimBilgileri.TabStop = false;
            this.grpIletisimBilgileri.Text = "İletişim Bilgisi Giriş Ekranı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(229, 232);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 61);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ev Adresi:";
            // 
            // txtEvAdresi
            // 
            this.txtEvAdresi.Location = new System.Drawing.Point(113, 109);
            this.txtEvAdresi.Multiline = true;
            this.txtEvAdresi.Name = "txtEvAdresi";
            this.txtEvAdresi.Size = new System.Drawing.Size(220, 117);
            this.txtEvAdresi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefonu:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(113, 70);
            this.txtTelefon.Mask = "(000) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(113, 32);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(220, 20);
            this.txtEposta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-posta Adresi:";
            // 
            // btnGirGuncelle
            // 
            this.btnGirGuncelle.Location = new System.Drawing.Point(28, 67);
            this.btnGirGuncelle.Name = "btnGirGuncelle";
            this.btnGirGuncelle.Size = new System.Drawing.Size(357, 43);
            this.btnGirGuncelle.TabIndex = 11;
            this.btnGirGuncelle.Text = "GİRİŞ VEYA GÜNCELLEME YAP";
            this.btnGirGuncelle.UseVisualStyleBackColor = true;
            this.btnGirGuncelle.Click += new System.EventHandler(this.btnGirGuncelle_Click);
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(28, 39);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(357, 21);
            this.cmbPersoneller.TabIndex = 10;
            this.cmbPersoneller.SelectedIndexChanged += new System.EventHandler(this.cmbPersoneller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İletişim Bilgilerini Gireceğiniz Personli Seçiniz:";
            // 
            // btnTumKayitlar
            // 
            this.btnTumKayitlar.Location = new System.Drawing.Point(230, 435);
            this.btnTumKayitlar.Name = "btnTumKayitlar";
            this.btnTumKayitlar.Size = new System.Drawing.Size(156, 44);
            this.btnTumKayitlar.TabIndex = 14;
            this.btnTumKayitlar.Text = "TÜM KAYITLAR";
            this.btnTumKayitlar.UseVisualStyleBackColor = true;
            this.btnTumKayitlar.Click += new System.EventHandler(this.btnTumKayitlar_Click);
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.Location = new System.Drawing.Point(32, 435);
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.Size = new System.Drawing.Size(156, 44);
            this.btnYeniPersonel.TabIndex = 13;
            this.btnYeniPersonel.Text = "YENİ PERSONEL";
            this.btnYeniPersonel.UseVisualStyleBackColor = true;
            this.btnYeniPersonel.Click += new System.EventHandler(this.btnYeniPersonel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 536);
            this.Controls.Add(this.grpIletisimBilgileri);
            this.Controls.Add(this.btnGirGuncelle);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTumKayitlar);
            this.Controls.Add(this.btnYeniPersonel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpIletisimBilgileri.ResumeLayout(false);
            this.grpIletisimBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIletisimBilgileri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEvAdresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirGuncelle;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTumKayitlar;
        private System.Windows.Forms.Button btnYeniPersonel;
    }
}