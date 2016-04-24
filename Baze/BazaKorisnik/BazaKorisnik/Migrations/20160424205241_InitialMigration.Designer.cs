using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using BazaKorisnik.BazaKorisnik.Models;

namespace BazaKorisnikMigrations
{
    [ContextType(typeof(KorisnikDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160424205241_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("BazaKorisnik.BazaKorisnik.Models.Korisnik", b =>
                {
                    b.Property<int>("korisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("password");

                    b.Property<string>("prezime");

                    b.Key("korisnikID");
                });
        }
    }
}
