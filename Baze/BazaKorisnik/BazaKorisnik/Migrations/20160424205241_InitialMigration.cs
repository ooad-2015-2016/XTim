using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace BazaKorisnikMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    korisnikID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    email = table.Column(type: "TEXT", nullable: true),
                    ime = table.Column(type: "TEXT", nullable: true),
                    password = table.Column(type: "TEXT", nullable: true),
                    prezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.korisnikID);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Korisnik");
        }
    }
}
