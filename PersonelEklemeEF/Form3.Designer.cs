namespace PersonelEklemeEF.UI
{
    partial class Form3
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
            this.grpPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.lblPersonelBilgileri = new System.Windows.Forms.Label();
            this.btnBilgileriTemizle = new System.Windows.Forms.Button();
            this.grpPersonelBul = new System.Windows.Forms.GroupBox();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.lbxPersoneller = new System.Windows.Forms.ListBox();
            this.cmbAramaSecenekleri = new System.Windows.Forms.ComboBox();
            this.txtAranacakSozcuk = new System.Windows.Forms.TextBox();
            this.btnAramaTemizle = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.grpPersonelBilgileri.SuspendLayout();
            this.grpPersonelBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonelBilgileri
            // 
            this.grpPersonelBilgileri.Controls.Add(this.lblPersonelBilgileri);
            this.grpPersonelBilgileri.Controls.Add(this.btnBilgileriTemizle);
            this.grpPersonelBilgileri.Location = new System.Drawing.Point(55, 46);
            this.grpPersonelBilgileri.Name = "grpPersonelBilgileri";
            this.grpPersonelBilgileri.Size = new System.Drawing.Size(310, 288);
            this.grpPersonelBilgileri.TabIndex = 3;
            this.grpPersonelBilgileri.TabStop = false;
            this.grpPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // lblPersonelBilgileri
            // 
            this.lblPersonelBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPersonelBilgileri.Location = new System.Drawing.Point(6, 16);
            this.lblPersonelBilgileri.Name = "lblPersonelBilgileri";
            this.lblPersonelBilgileri.Size = new System.Drawing.Size(298, 224);
            this.lblPersonelBilgileri.TabIndex = 1;
            // 
            // btnBilgileriTemizle
            // 
            this.btnBilgileriTemizle.Location = new System.Drawing.Point(44, 247);
            this.btnBilgileriTemizle.Name = "btnBilgileriTemizle";
            this.btnBilgileriTemizle.Size = new System.Drawing.Size(179, 33);
            this.btnBilgileriTemizle.TabIndex = 0;
            this.btnBilgileriTemizle.Text = "TEMİZLE";
            this.btnBilgileriTemizle.UseVisualStyleBackColor = true;
            this.btnBilgileriTemizle.Click += new System.EventHandler(this.btnBilgileriTemizle_Click);
            // 
            // grpPersonelBul
            // 
            this.grpPersonelBul.Controls.Add(this.btnPersonelAra);
            this.grpPersonelBul.Controls.Add(this.lbxPersoneller);
            this.grpPersonelBul.Controls.Add(this.cmbAramaSecenekleri);
            this.grpPersonelBul.Controls.Add(this.txtAranacakSozcuk);
            this.grpPersonelBul.Controls.Add(this.btnAramaTemizle);
            this.grpPersonelBul.Location = new System.Drawing.Point(404, 46);
            this.grpPersonelBul.Name = "grpPersonelBul";
            this.grpPersonelBul.Size = new System.Drawing.Size(310, 288);
            this.grpPersonelBul.TabIndex = 4;
            this.grpPersonelBul.TabStop = false;
            this.grpPersonelBul.Text = "Personel Bul";
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(231, 27);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(73, 21);
            this.btnPersonelAra.TabIndex = 5;
            this.btnPersonelAra.Text = "ARA";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // lbxPersoneller
            // 
            this.lbxPersoneller.FormattingEnabled = true;
            this.lbxPersoneller.Location = new System.Drawing.Point(25, 54);
            this.lbxPersoneller.Name = "lbxPersoneller";
            this.lbxPersoneller.Size = new System.Drawing.Size(279, 186);
            this.lbxPersoneller.TabIndex = 4;
            this.lbxPersoneller.DoubleClick += new System.EventHandler(this.lbxPersoneller_DoubleClick);
            // 
            // cmbAramaSecenekleri
            // 
            this.cmbAramaSecenekleri.FormattingEnabled = true;
            this.cmbAramaSecenekleri.Items.AddRange(new object[] {
            "ile başlayanlar",
            "içerenler",
            "ile bitenler"});
            this.cmbAramaSecenekleri.Location = new System.Drawing.Point(98, 27);
            this.cmbAramaSecenekleri.Name = "cmbAramaSecenekleri";
            this.cmbAramaSecenekleri.Size = new System.Drawing.Size(127, 21);
            this.cmbAramaSecenekleri.TabIndex = 3;
            // 
            // txtAranacakSozcuk
            // 
            this.txtAranacakSozcuk.Location = new System.Drawing.Point(25, 27);
            this.txtAranacakSozcuk.Name = "txtAranacakSozcuk";
            this.txtAranacakSozcuk.Size = new System.Drawing.Size(65, 20);
            this.txtAranacakSozcuk.TabIndex = 2;
            // 
            // btnAramaTemizle
            // 
            this.btnAramaTemizle.Location = new System.Drawing.Point(65, 247);
            this.btnAramaTemizle.Name = "btnAramaTemizle";
            this.btnAramaTemizle.Size = new System.Drawing.Size(179, 33);
            this.btnAramaTemizle.TabIndex = 1;
            this.btnAramaTemizle.Text = "TEMİZLE";
            this.btnAramaTemizle.UseVisualStyleBackColor = true;
            this.btnAramaTemizle.Click += new System.EventHandler(this.btnAramaTemizle_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(99, 350);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(549, 33);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 419);
            this.Controls.Add(this.grpPersonelBilgileri);
            this.Controls.Add(this.grpPersonelBul);
            this.Controls.Add(this.btnAnaMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpPersonelBilgileri.ResumeLayout(false);
            this.grpPersonelBul.ResumeLayout(false);
            this.grpPersonelBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonelBilgileri;
        private System.Windows.Forms.Label lblPersonelBilgileri;
        private System.Windows.Forms.Button btnBilgileriTemizle;
        private System.Windows.Forms.GroupBox grpPersonelBul;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.ListBox lbxPersoneller;
        private System.Windows.Forms.ComboBox cmbAramaSecenekleri;
        private System.Windows.Forms.TextBox txtAranacakSozcuk;
        private System.Windows.Forms.Button btnAramaTemizle;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}