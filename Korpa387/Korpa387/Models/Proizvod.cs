using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Korpa387.Models
{
    public class Proizvod
    {
        public int ID { get; set; }
        public long Barkod { get; set; }
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObjave { get; set; }
        public byte[] Fotografija { get; set; }

        public virtual ICollection<Recenzija> Recenzije { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
    }
}