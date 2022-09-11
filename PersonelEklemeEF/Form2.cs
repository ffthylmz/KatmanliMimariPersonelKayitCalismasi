using PersonelEklemeEF.DAL;
using PersonelEklemeEF.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelEklemeEF.UI
{
    public partial class Form2 : Form
    {
        Context db;
        Metotlar mt = new Metotlar();
        //IletisimBilgisi iBilgi;
        Form1 anaform;
        public Form2()
        {
            InitializeComponent();
            anaform = new Form1();
            db = new Context();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //List<Personel> people = db.Personeller.ToList();

            //foreach (var item in people)
            //{
            //    cmbPersoneller.Items.Add(item.FullName);
            //}

            cmbPersoneller.DataSource = db.Personeller.ToList();
            cmbPersoneller.DisplayMember = "FullName";
            cmbPersoneller.ValueMember = "PersonelID";
            cmbPersoneller.SelectedIndex = -1;
            btnGirGuncelle.Enabled = false;
        }

        private void btnGirGuncelle_Click(object sender, EventArgs e)
        {
            IletisimBilgisi bilgi = new IletisimBilgisi();
            bilgi = db.IletisimBilgileri.FirstOrDefault(a => a.PersonelID == (int)cmbPersoneller.SelectedValue);


            if (bilgi != null)
            {
                txtEposta.Text = bilgi.Email;
                txtEvAdresi.Text = bilgi.Adres;
                txtTelefon.Text = bilgi.Telefon;
            }
            else
                MessageBox.Show("Seçilen kişiye ait iletişim bilgisi yoktur.");

        }

        private void cmbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGirGuncelle.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IletisimBilgisi iBilgi = db.IletisimBilgileri.FirstOrDefault(a => a.PersonelID == (int)cmbPersoneller.SelectedValue);

            if (iBilgi == null)
            {
                iBilgi = new IletisimBilgisi()
                {
                    PersonelID = (int)cmbPersoneller.SelectedValue,
                    Email = txtEposta.Text,
                    Adres = txtEvAdresi.Text,
                    Telefon = txtTelefon.Text,
                };
                db.IletisimBilgileri.Add(iBilgi);
                db.SaveChanges();
            }
            else
            {
                iBilgi.Email = txtEposta.Text;
                iBilgi.Adres = txtEvAdresi.Text;
                iBilgi.Telefon = txtTelefon.Text;
                db.SaveChanges();
            }

           // db.SaveChanges();
            mt.GroupBoxTemizle(grpIletisimBilgileri);
            cmbPersoneller.SelectedIndex = 0;
            btnGirGuncelle.Enabled = false;



            //if (bilgi != null)
            //{

            //    bilgi.Email = txtEposta.Text;
            //    bilgi.Adres = txtEvAdresi.Text;
            //    bilgi.Telefon = txtTelefon.Text;

            //    db.SaveChanges();

            //    MessageBox.Show("Kayıt Güncellenmiştir.");
            //    mt.GroupBoxTemizle(grpIletisimBilgileri);
            //}
            //else
            //{
            //    bilgi = new IletisimBilgisi();
            //    bilgi.Email = txtEposta.Text;
            //    bilgi.Adres = txtEvAdresi.Text;
            //    bilgi.Telefon = txtTelefon.Text;

            //    db.SaveChanges();

            //    MessageBox.Show("Kayıt Başarılı.");
            //    mt.GroupBoxTemizle(grpIletisimBilgileri);
            //}
        }

        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            anaform.Show();
            Hide();
        }

        private void btnTumKayitlar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Hide();
            form3.Show();
        }
    }
}
