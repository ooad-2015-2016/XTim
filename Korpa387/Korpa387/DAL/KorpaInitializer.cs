using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Korpa387.Models;

namespace Korpa387.DAL
{
    public class KorpaInitializer : System.Data.Entity.DropCreateDatabaseAlways<Korpa387Context>
    {
        protected override void Seed(Korpa387Context context)
        {
            var korisnici = new List<Korisnik>
            {
                new Korisnik { ImePrezime="Admira Husic", Email="admira@example.com", Password="admirah", Fotografija =new byte[1], Role=1 },
                new Korisnik { ImePrezime="Belmin Mustajbasic", Email="belmin@example.com", Password="belminm", Fotografija =new byte[1], Role=1 },
                new Korisnik { ImePrezime="The Admin", Email="admin@example.com", Password="admin", Fotografija =new byte[1], Role=0 }
            };
            korisnici.ForEach(s => context.Korisnici.Add(s));
            context.SaveChanges();

            var proizvodjaci = new List<Proizvodjac>
            {
                new Proizvodjac {Naziv="HIFA Oil", Email="hifa@example.com",Password="test", Opis="Distributer naftnih derivata", Lokacija="Tesanj", Fotografija=new byte[1] },
                new Proizvodjac {Naziv="Kent", Email="kent@example.com",Password="test", Opis="Proizvodjač najukusnijeg Keksa u BiH", Lokacija="Jelah", Fotografija=new byte[1] },
                new Proizvodjac {Naziv="Vispak", Email="vispak@example.com",Password="test", Opis="Dugogodišnja tradicija zarne prehrambene industrije", Lokacija="Sarajevo", Fotografija=new byte[1] }
            };
            proizvodjaci.ForEach(s => context.Proizvodjaci.Add(s));
            context.SaveChanges();

            var proizvodi = new List<Proizvod>
            {
                new Proizvod {Barkod=387123456789,ProizvodjacID=1, Naziv="Motorno ulje 2016", Opis="Najbolje motorno ulje na tržištiu", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Petit Keks", Opis="Keks da se obaljutneš", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Brašno Tip 400", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Čoko Kent", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Double kent keks", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Čoksa", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Kinderlada Aluminium", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Reno Clio", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=2, Naziv="Mehanička tastatura", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Megle Mlijeko", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Marshall pojačalo", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Brašno Tip 500", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Sarajevski Kiseljak", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },
                new Proizvod {Barkod=387123456789,ProizvodjacID=3, Naziv="Oaza Tešanj", Opis="za sve pekarske proizvode a bogme i za vaš dom", DatumObjave=DateTime.Parse("2015-5-5"), Fotografija= new byte[1] },

            };
            proizvodi.ForEach(s => context.Proizvodi.Add(s));
            context.SaveChanges();

            var recenzije = new List<Recenzija>
            {
                new Recenzija {KorisnikID=1, ProizvodID=1, Tekst="Super Proizvod, volim domaće!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },
                new Recenzija {KorisnikID=2, ProizvodID=2, Tekst="S obzirom da je domaće, dobro je. Jelah miriše divno na keks!", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },
                new Recenzija {KorisnikID=2, ProizvodID=3, Tekst="Uvijek korisnim ovo brašno kada kuham.", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },
                new Recenzija {KorisnikID=2, ProizvodID=3, Tekst="Uvijek korisnim ovo brašno kada kuham.", Datum=DateTime.Parse("2015-5-5"), Ocjena=2 },
                new Recenzija {KorisnikID=2, ProizvodID=3, Tekst="Uvijek korisnim ovo brašno zutregefe erf ergsdfrtere ertert errrr kada kuham.", Datum=DateTime.Parse("2015-5-5"), Ocjena=1 },

            };
            recenzije.ForEach(s => context.Recenzije.Add(s));
            context.SaveChanges();
        }

    }
}