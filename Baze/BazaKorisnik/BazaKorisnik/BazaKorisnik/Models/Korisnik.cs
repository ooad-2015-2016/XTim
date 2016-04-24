using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazaKorisnik.BazaKorisnik.Models
{
    class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int korisnikID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        // public List<Proizvod> Proizvodi { get; set; }
        // public List<Recenzija> Recenzije { get; set; }
    }
}
