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
    public partial class Form1 : Form
    {
        Context db;
        public Form1()
        {
            InitializeComponent();
            db = new Context();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Metotlar mt = new Metotlar();
            if (mt.GroupBoxBosAlanVarMi(grpPersonelEkle))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else
            {
                Personel personel = db.Personeller.FirstOrDefault(a => a.PersonelTC == txtPersonelTCNo.Text);
                if (personel is null)
                {
                    personel = new Personel()
                    {
                        Birim = cmbBirimler.Text,
                        Ad = txtPersonelAdi.Text,
                        Soyad = txtPersonelSoyadi.Text,
                        DogumTarihi = dtPersonelDogumTarihi.Value,
                        Cinsiyet = rdoErkek.Checked,
                        PersonelTC = txtPersonelTCNo.Text
                    };

                    db.Personeller.Add(personel);
                    db.SaveChanges();

                    btnIletisimBilgileri.Enabled = btnTemizle.Enabled = true;
                    MessageBox.Show("Personel Eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numarasına ait kayıt bulunmaktadır!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoErkek.Checked = true;
            btnTemizle.Enabled = false;

            btnIletisimBilgileri.Enabled = db.Personeller.ToList().Count > 0 ? true : false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Metotlar mt = new Metotlar();
            mt.GroupBoxTemizle(grpPersonelEkle);
        }

        private void btnIletisimBilgileri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
