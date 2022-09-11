using PersonelEklemeEF.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEklemeEF.DAL
{
    public class PersonelMapping : EntityTypeConfiguration<Personel>
    {
        public PersonelMapping()
        {
            this.ToTable("Personeller");
            this.HasKey(a => a.PersonelID);
            this.Property(a => a.PersonelTC).HasMaxLength(11).IsRequired().HasColumnType("CHAR");
            this.Property(b => b.Ad).HasMaxLength(20).IsRequired();
            this.Property(b => b.Soyad).HasMaxLength(20).IsRequired();
            this.Property(b => b.Cinsiyet).IsRequired();
            this.Property(b => b.DogumTarihi).IsOptional();
            this.Property(b => b.Birim).IsRequired().HasMaxLength(20);
            this.Ignore(b => b.FullName);

            //Navigation

            this.HasRequired(a => a.IletisimBilgisi).WithRequiredPrincipal(a => a.Personel);
        }

    }
}
