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

namespace PersonelEklemeEF.UI
{
    public partial class Form3 : Form
    {
        Context db;
        Metotlar mt;
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new Context();
        }

        private void btnBilgileriTemizle_Click(object sender, EventArgs e)
        {
            mt = new Metotlar();
            mt.GroupBoxTemizle(grpPersonelBilgileri);
        }

        private void btnAramaTemizle_Click(object sender, EventArgs e)
        {
            mt = new Metotlar();
            mt.GroupBoxTemizle(grpPersonelBul);
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            mt = new Metotlar();

            if (mt.GroupBoxBosAlanVarMi(grpPersonelBul))
            {
                MessageBox.Show("Lütfen aranacak sözcük ve arama seçeneğini doldurunuz!");
            }
            else
            {
                if (cmbAramaSecenekleri.SelectedIndex == 0) // ile başlayan
                {
                    List<Personel> people = db.Personeller.Where(a => a.Ad.StartsWith(txtAranacakSozcuk.Text) || a.Soyad.StartsWith(txtAranacakSozcuk.Text)).ToList();

                    lbxPersoneller.DataSource = people;
                    lbxPersoneller.DisplayMember = "FullName";
                    lbxPersoneller.ValueMember = "PersonelID";

                }
                else if (cmbAramaSecenekleri.SelectedIndex == 1) // içerenler
                {
                    List<Personel> people = db.Personeller.Where(a => a.Ad.Contains(txtAranacakSozcuk.Text) || a.Soyad.Contains(txtAranacakSozcuk.Text)).ToList();

                    lbxPersoneller.DataSource = people;
                    lbxPersoneller.DisplayMember = "FullName";
                    lbxPersoneller.ValueMember = "PersonelID";
                }
                else if (cmbAramaSecenekleri.SelectedIndex == 2) // ile bitenler
                {
                    List<Personel> people = db.Personeller.Where(a => a.Ad.EndsWith(txtAranacakSozcuk.Text) || a.Soyad.EndsWith(txtAranacakSozcuk.Text)).ToList();

                    lbxPersoneller.DataSource = people;
                    lbxPersoneller.DisplayMember = "FullName";
                    lbxPersoneller.ValueMember = "PersonelID";
                }
            }


        }

        private void lbxPersoneller_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel = db.Personeller.Find((int)lbxPersoneller.SelectedValue);

            IletisimBilgisi secilenPersonelIletisimBilgisi = db.IletisimBilgileri.Find((int)lbxPersoneller.SelectedValue);

            lblPersonelBilgileri.Text = "Adı: " + secilenPersonel.Ad + "\nSoyadı: " + secilenPersonel.Soyad + "\nCinsiyeti: " + (secilenPersonel.Cinsiyet ? "Erkek" : "False") + "\nDoğum Tarihi: " + secilenPersonel.DogumTarihi + "\nE-mail: " + secilenPersonelIletisimBilgisi.Email + "\nAdres: " + secilenPersonelIletisimBilgisi.Adres + "\nTelefon: " + secilenPersonelIletisimBilgisi.Telefon;
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();            
            form1.Show();
        }
    }
}
