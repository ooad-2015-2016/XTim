using System;
using System.Collections.Generic;

namespace Korpa387.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Fotografija { get; set; }
        public int Role { get; set; }

        public virtual ICollection<Recenzija> Recenzije { get; set; }
    }
}