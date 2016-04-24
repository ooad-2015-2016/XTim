using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodBa.ProizvodBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(ProizvodDbContext context)
        {
            if (!context.proizvodi.Any())
            {
                context.proizvodi.AddRange(
                new Proizvod()
                {
                    naziv = "neki",
                    sifra = "asdasdas062238267asdasds",
                    sastav = new string[] {""},
                    tezina = 100,
                    cijena = 17.5f,
                    mjestoProizvodnje = "negdje",
                }
                );
                context.SaveChanges();
            }
        }
    }
}
