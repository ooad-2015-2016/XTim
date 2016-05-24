using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Korpa387.Models
{
    public class Proizvodjac
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Lokacija { get; set; }
        public byte[] Fotografija { get; set; }

        public virtual ICollection<Proizvod> Proizvodi { get; set; }
    }
}