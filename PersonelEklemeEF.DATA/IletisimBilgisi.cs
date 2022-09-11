using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEklemeEF.DATA
{
    public class IletisimBilgisi
    {
        public int PersonelID { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        
        //Navigation Property
        public Personel Personel { get; set; }
    }
}
