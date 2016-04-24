using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProizvodBa.ProizvodBaza.Models;

namespace ProizvodMigrations
{
    [ContextType(typeof(ProizvodDbContext))]
    partial class ProizvodDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Proizvod.ProizvodBaza.Models.Proizvod", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("cijena");

                    b.Property<string>("mjestoProizvodnje");

                    b.Property<string>("naziv");

                    b.Property<string>("sifra");

                    b.Property<double>("tezina");

                    b.Key("ProizvodId");
                });
        }
    }
}
