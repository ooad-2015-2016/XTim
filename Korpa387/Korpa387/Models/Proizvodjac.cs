using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Korpa387.Models
{
    public class Proizvodjac
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [DataType(DataType.MultilineText)]
        public string Opis { get; set; }
        public string Lokacija { get; set; }
        public string Fotografija { get; set; }

        public virtual ICollection<Proizvod> Proizvodi { get; set; }
    }
}