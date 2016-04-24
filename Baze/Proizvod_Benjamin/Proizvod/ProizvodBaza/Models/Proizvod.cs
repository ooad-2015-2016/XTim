using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;


namespace ProizvodBa.ProizvodBaza.Models
{
    class Proizvod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProizvodId { get; set; }
        public string naziv { get; set; }
        public string sifra { get; set; }
        public string[] sastav{ get; set; }
        public double tezina { get; set; }
        //public Proizvodjac proizvodjac { get; set; }
        public double cijena { get; set; }
        public string mjestoProizvodnje { get; set; }
       // public Pitanje[] pitanja {get;set;}
    }
}
