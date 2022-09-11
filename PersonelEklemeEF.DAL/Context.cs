using PersonelEklemeEF.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEklemeEF.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Server=ASUS\\SQLEXPRESS; Database=PersonelKayitDB; Trusted_Connection=True;")
        {
            //ya base() kullanarak Database bağlayabiliriz, ya da aşağıdaki gibi SQL'e bağlantı kurabiliriz.

            //Database.Connection.ConnectionString = "Server=ASUS\\SQLEXPRESS; Database=PersonelKayitDB; Trusted_Connection=True;";
        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonelMapping());
            modelBuilder.Configurations.Add(new IletisimBilgisiMapping());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}
