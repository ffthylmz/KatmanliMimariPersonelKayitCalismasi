using PersonelEklemeEF.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEklemeEF.DAL
{
    public class IletisimBilgisiMapping : EntityTypeConfiguration<IletisimBilgisi>
    {
        public IletisimBilgisiMapping()
        {
            this.ToTable("IletisimBilgileri");
            this.HasKey(a => a.PersonelID);
            this.Property(a => a.Email).HasMaxLength(50).IsRequired().HasColumnType("nchar");
            this.Property(a => a.Telefon).HasMaxLength(15).IsRequired().HasColumnType("varchar");
            this.Property(a => a.Adres).HasMaxLength(100).IsRequired();

            //Navigation 
            //diğer tabloda birebir ilişkiyi yazdığımız için buraya da yazmaya gerek kalmıyor (1-1 ilişkilerde)
            
            // this.HasRequired(a => a.Personel).WithRequiredPrincipal(a => a.IletisimBilgisi);

        }
    }
}
