using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodjacBaza.ProizvodjacBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(ProizvodjacDbContext context)
        {
            if (!context.Proizvodjaci.Any())
            {
                context.Proizvodjaci.AddRange(new Proizvodjac() { Naziv = "Neka kompanija", Telefon = "0000000000", Adresa="negdje nedefinisano", Ocjena = 3, }); context.SaveChanges();
            }
        }
    }
}
