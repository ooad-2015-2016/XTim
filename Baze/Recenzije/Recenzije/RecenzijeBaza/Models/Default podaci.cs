using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recenzije.RecenzijeBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(RecenzijaDbContext context)
        {
            if (!context.Recenzije.Any())
            {
                context.Recenzije.AddRange(new Recenzija() { Komentar = "Neki komentar", Datum = DateTime.Today }); context.SaveChanges();
            }
        }
    }
}
