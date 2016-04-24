using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Recenzije.RecenzijeBaza.Models;

namespace RecenzijeMigrations
{
    [ContextType(typeof(RecenzijaDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160424192649_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
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
