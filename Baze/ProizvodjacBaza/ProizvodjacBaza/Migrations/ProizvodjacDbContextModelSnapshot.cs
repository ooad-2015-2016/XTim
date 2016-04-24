using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using ProizvodjacBaza.ProizvodjacBaza.Models;

namespace ProizvodjacBazaMigrations
{
    [ContextType(typeof(ProizvodjacDbContext))]
    partial class ProizvodjacDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("ProizvodjacBaza.ProizvodjacBaza.Models.Proizvodjac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Naziv");

                    b.Property<float>("Ocjena");

                    b.Property<string>("Telefon");

                    b.Key("Id");
                });
        }
    }
}
