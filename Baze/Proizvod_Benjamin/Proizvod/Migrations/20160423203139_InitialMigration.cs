using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace ProizvodMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodId = table.Column(type: "INTEGER", nullable: false),
                      //  .Annotation("Sqlite:Autoincrement", true),
                    cijena = table.Column(type: "REAL", nullable: false),
                    mjestoProizvodnje = table.Column(type: "TEXT", nullable: true),
                    naziv = table.Column(type: "TEXT", nullable: true),
                    sifra = table.Column(type: "TEXT", nullable: true),
                    tezina = table.Column(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Proizvod");
        }
    }
}
