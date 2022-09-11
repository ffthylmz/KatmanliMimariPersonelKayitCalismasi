using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEklemeEF.DATA
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelTC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FullName
        {
            get { return this.Ad + " " + this.Soyad; }
        }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Birim { get; set; }

        //Navigation Property

        public IletisimBilgisi IletisimBilgisi { get; set; }


    }
}
