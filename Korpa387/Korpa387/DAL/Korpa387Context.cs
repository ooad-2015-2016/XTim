using Korpa387.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Korpa387.DAL
{
    public class Korpa387Context : DbContext
    {
        public Korpa387Context() : base("Korpa387Context")
        {
        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Proizvodjac> Proizvodjaci { get; set; }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}