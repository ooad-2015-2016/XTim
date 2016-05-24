using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Korpa387.Models
{
    public class Recenzija
    {
        public int ID { get; set; }
        public int KorisnikID { get; set; }
        public int ProizvodID { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; } // 1-5

        public virtual Korisnik Korisnik { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}