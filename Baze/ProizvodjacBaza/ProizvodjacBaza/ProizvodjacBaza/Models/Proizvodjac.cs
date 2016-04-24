using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodjacBaza.ProizvodjacBaza.Models
{
    class Proizvodjac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }//primary key u bazi
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        //public List<Proizvod> Proizvodi { get; set; }
        public List<String> Proizvodi { get; set; }
        public float Ocjena { get; set; }
    }
}
