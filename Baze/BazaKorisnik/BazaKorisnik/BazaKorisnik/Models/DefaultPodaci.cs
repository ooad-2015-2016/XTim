using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaKorisnik.BazaKorisnik.Models
{
    class DefaultPodaci
    {
        public static void Initialize(KorisnikDbContext context)
        {
            if (!context.Korisnici.Any())
            {
                context.Korisnici.AddRange(new Korisnik()
                {
                    korisnikID = 0,
                    ime = "imeKorisnika",
                    prezime = "prezimeKorisnika",
                    email = "email@google.com",
                    password = "VeomaSiguranPassword123",
                }); context.SaveChanges();
            }
        }
    }
}
