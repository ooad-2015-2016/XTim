using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProizvodjacBaza.ProizvodjacBaza.Models
{
    class ProizvodjacDbContext : DbContext
    {

        public DbSet<Proizvodjac> Proizvodjaci { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "Proizvodjacbaza.db";
            try
            {

                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza             
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

    }
}