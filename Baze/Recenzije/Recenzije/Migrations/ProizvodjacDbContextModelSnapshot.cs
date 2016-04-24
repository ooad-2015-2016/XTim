using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Recenzije.RecenzijeBaza.Models;

namespace RecenzijeMigrations
{
    [ContextType(typeof(RecenzijaDbContext))]
    partial class ProizvodjacDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Recenzije.RecenzijeBaza.Models.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Komentar");

                    b.Property<DateTime>("datum");

                    b.Key("Id");
                });
        }
    }
}
