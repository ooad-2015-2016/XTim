using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace Recenzije.RecenzijeBaza.Models
{
    class Recenzija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }     //primary key u bazi
        //ocjena Ocjena { get; set; }
        public string Komentar { get; set; }
        //korisnik Korisnik { get; set; }
        //proizvod Proizvod { get; set; }
        public DateTime Datum { get; set; }
    }
}
