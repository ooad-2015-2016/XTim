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
                new Korisnik { ImePrezime="The Admin", Email="admin@example.com", Password="admin", Fotografija ="fotka.jpg", Role=0 },
                new Korisnik { ImePrezime="Testni Korisnik", Email="korisnik@example.com", Password="korisnik", Fotografija ="fotka.jpg", Role=1 },
                new Korisnik { ImePrezime="Kemal Halilbehović", Email="kemal@example.com", Password="test", Fotografija ="fotka.jpg", Role=1 },
                new Korisnik { ImePrezime="Belmin Mustajbašić", Email="belmin@example.com", Password="test", Fotografija ="fotka.jpg", Role=1 },
                new Korisnik { ImePrezime="Haris Halilović", Email="haris@example.com", Password="test", Fotografija ="fotka.jpg", Role=1 },
                new Korisnik { ImePrezime="Benjamin Hrustemović", Email="benjamin@example.com", Password="test", Fotografija ="fotka.jpg", Role=1 }

            };
            korisnici.ForEach(s => context.Korisnici.Add(s));
            context.SaveChanges();

            var proizvodjaci = new List<Proizvodjac>
            {
                new Proizvodjac {Naziv="HIFA Oil", Email="hifa@bih.net.ba",Password="test", Opis="Distributer naftnih derivata", Lokacija="Tesanj", Fotografija="hifa.jpg"},
                new Proizvodjac {Naziv="Sarajevska pivara", Email="info@pivara.ba",Password="test", Opis="Pivara", Lokacija="Sarajevo", Fotografija="spivara.png"},
                new Proizvodjac {Naziv="Pivara tuzla", Email="pivara@pivaratuzla.ba",Password="test", Opis="Pivara", Lokacija="Tuzla", Fotografija="PivaraTuzla.png"},
                new Proizvodjac {Naziv="Meggle BiH", Email="info@meggle.ba",Password="test", Opis="Mljekara", Lokacija="Posušje", Fotografija="meggle.png"},
                new Proizvodjac {Naziv="Bosnalijek", Email="info@bosnalijek.ba",Password="test", Opis="Industrijski proizvođač lijekova", Lokacija="Sarajevo", Fotografija="bosnalijek.jpg"},
                new Proizvodjac {Naziv="Bekto Precisa", Email="info@bekto.com",Password="test", Opis="Proizvođač visokosofisticiranih industrijskih alata za plastiku i obojene metale", Lokacija="Goražde", Fotografija="bosnalijek.jpg"},
                new Proizvodjac {Naziv="Violeta", Email="violeta@violeta.com",Password="test", Opis="Brend je lansiran 2002. i za više od deset godina postojanja postao je jedan od najprepoznatljivih brandova higijenskih proizvoda premium klase.", Lokacija="Grude", Fotografija="startbih_2015062905474494_big.jpg"},
                new Proizvodjac {Naziv = "Klas", Email = "marketing@klas.ba", Password = "test", Opis = "Klas d.d. Sarajevo, s tradicijom dugom 113 godina (osnovan 1902.), vodeći je bh. proizvođač u mlinsko-pekarskoj djelatnosti, te među vodećim proizvođačima tjestenine, slastičarskih i konditorskih proizvoda u BiH i regionu.", Lokacija = "Sarajevo", Fotografija = "klas.jpg" },
                new Proizvodjac {Naziv = "Fabrika duhana Sarajevo", Email = "/", Password = "test", Opis = "Vodeća kompanija u duhanskoj industriji na području BiH preko 135 godina.", Lokacija = "Sarajevo", Fotografija = "fds-vest.jpg" },
                new Proizvodjac {Naziv = "Dita", Email = "komercijala-marketing@dita.ba", Password = "test", Opis = "Dita d.d. industrija deterdženata Tuzla je osnovana 26. juna 1977. godine zajedničkim ulaganjem kombinata “SODASO” Tuzla i italijanske firme “MIRA LANZA” iz Đenove.", Lokacija = "Tuzla", Fotografija = "Dita-logo-e1453041347803.png" },
                new Proizvodjac {Naziv = "Solana Tuzla", Email = "solana@solana.ba", Password = "test", Opis = "Proizvodnja soli i zacina.", Lokacija = "Tuzla", Fotografija = "Dita-logo-e1453041347803.png" },
                new Proizvodjac {Naziv = "Vitaminka", Email = "vitaminka@vitaminka-kreis.com", Password = "test", Opis = "Već 69 godina. Naši stručnjaci kombinuju tajne starih majstora sa novim saznanjima, biraju najbolje voće i povrće, koriste najbolje začine, te vam omogućavaju ne samo da jedete, već prije svega i da uživate u hrani.", Lokacija = "Banja Luka", Fotografija = "logo_stroke1.png" }
            };
            proizvodjaci.ForEach(s => context.Proizvodjaci.Add(s));
            context.SaveChanges();

            var proizvodi = new List<Proizvod>
            {
                new Proizvod {Barkod=387123456789,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline 10W - 40", Opis=" visoko učinkovito polusintetičko multigradno motorno ulje, koje omogućava produžene intervale zamjene i upotrebljava se za podmazivanje benzinskih ili dieselmotora, sa ili bez turbo punjača.", Fotografija="10w-40.jpg" },

new Proizvod {Barkod=26972,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline 5w-40", Opis="visoko učinkovito potpuno sintetičko multigradno motorno ulje, koje omogućava produžene intervale zamjene i upotrebljava se za podmazivanje benzinskih ili diesel  EURO-4 motora, sa ili bez turbo punjača.", Fotografija="5w-40.jpg" },

new Proizvod {Barkod=387123456791,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline SF/CD 15W - 40", Opis="učinkovito multigradno motorno ulje, koje se upotrebljava za podmazivanje benzinskih ili diesel motora, sa ili bez turbo punjača.", Fotografija="15w-40.jpg" },

new Proizvod {Barkod=387123456792,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline Piloil 100", Opis="ulje za podmazivanje vodilica i lanaca motornih pila. Proizvedeno na bazi kvalitetnih mineralnih ulja i dodataka za smanjenje habanja  i inhibitora korozije i dodataka za bolju prijemljivost na metalne površine.", Fotografija="piloil100.jpg" },

new Proizvod {Barkod=387123456793,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline Hydrofluid VG 46", Opis="Hidraulična ulja za najviše zahtjeve. ", Fotografija="hydrofluidVG46.jpg" },

new Proizvod {Barkod=387123456794,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline SAE 10W-40", Opis="motorno ulje visoke izdržljivosti (UHPD - ultra high performance diesel) za dizel motore sa produženim intervalom zamjene (long drain), namjenjeno novoj generaciji EURO-4 i EURO-5 dizel motora sa SCR tehnologijom (AdBlue) obrade izduvnih plinova.", Fotografija="sae10w-40.jpg" },

new Proizvod {Barkod=387123456795,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline SHPD SAE 15W-40", Opis="motorno ulje visoke izdržljivosti (UHPD - ultra high performance diesel) za dizel motore sa produženim intervalom zamjene (long drain).", Fotografija="sae15w-40.jpg" },

new Proizvod {Barkod=387123456795,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline Kristal", Opis="sredstvo za čišćenje vjetrobranskog stakla, otporno na smrzavanje do -25°C.", Fotografija="kristal.jpg" },

new Proizvod {Barkod=387123456796,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline SF/CD SAE 30", Opis="učinkovito monogradno motorno ulje, koje upotrebljavamo za podmazivanje benzinskih ili diesel motora, sa ili bez turbo punjača.", Fotografija="sae30.jpg" },

new Proizvod {Barkod=387123456797,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HGline SAE 90", Opis="višenamjensko hipoidno ulje sa EP osobinama. Upotrebljava se za podmazivanje svih vrsta mehaničkih prenosnika motornih vozila.", Fotografija="sae90.jpg" },

new Proizvod {Barkod=387123456798,ProizvodjacID=1, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Freeze STOP 100", Opis="nerazrijeđeno, za okolinu prihvatljivo sredstvo za hlađenje motora, protiv smrzavanja i korozije.", Fotografija="freeze-stop-100.jpg" },

new Proizvod {Barkod=387123456799,ProizvodjacID=2, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Sarajevsko pivo 2l", Opis="Sarajevsko u PET ambalaži od 2 litra je svijetlo lager pivo.", Fotografija="2l.png" },

new Proizvod {Barkod=68617,ProizvodjacID=2, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Sarajevsko bezalkoholno pivo", Opis="Sarajevsko bezalkoholno je svijetlo lager pivo, sa 0 % alkohola. Sadržaj ekstrakta je 6,5 %. Dostupno je u nepovratnoj staklenoj ambalaži 0,33 i limenci 0,5 l.", Fotografija="2l.png" },

new Proizvod {Barkod=387123456801,ProizvodjacID=2, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Sarajevsko Premium je svijetlo lager pivo", Opis="Proizvodi se iz  ječmenog slada, hmelja, prirodne izvorske vode i kvasca. Premium  je poseban zbog aromatičnosti koju ima iz slada i hmelja. Sadržaj alkohola je 4,9 %, a  ekstrakta 12 %.  Dostupan je u staklenoj boci s preklopnim zatvaračem.", Fotografija="premium-hs_self.png" },

new Proizvod {Barkod=387123456802,ProizvodjacID=2, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Sarajevska voda", Opis="Prirodna izvorska voda sa vlastitog izvora. Dostupna je u PET ambalaži 0,33, 0,5, 1,5 l i staklenoj nepovratnoj ambalaži 0,25 l.", Fotografija="obicna.png" },

new Proizvod {Barkod=387123456803,ProizvodjacID=3, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Tuzlanski pilsner", Opis="Tuzlanski pilsner je najstariji brand Pivare Tuzla a koji se proizvodi po veoma zahtjevnoj i staroj recepturi, na potpuno prirodan način.", Fotografija="tpilsner.jpg" },

new Proizvod {Barkod=387123456804,ProizvodjacID=3, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Erster pivo", Opis="Izuzetna vrsta svijetlog piva, proizvedena je od kvalitetnih sirovina, tehnologijom donjega vrenja sa sadržajem ekstrakta u osnovnoj sladovini 10,2° B. Sa sadržajem alkohola do 4,3 %.", Fotografija="erster.jpg" },

new Proizvod {Barkod=387123456805,ProizvodjacID=3, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Tuzlanski kiseljak", Opis="Tuzlanski kiseljak je prirodna mineralna voda bogata magnezijem i drugim mineralima (cinkom, kalcijumom, kalijumom) i mikroelementima (bakrom, cinkom, stroncijumom, molibden, vanadijumom, selen).", Fotografija="tkiseljak.jpg" },

new Proizvod {Barkod=387123456806,ProizvodjacID=3, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Premium crno pivo", Opis="Ovo pivo se proizvodilo do sredine 70-tih godina prošlog vijeka nakon čega je bilo ukinuto.", Fotografija="crnot.jpg" },

new Proizvod {Barkod=387123456807,ProizvodjacID=4, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="TRAJNO MLIJEKO 3,2 % m.m.", Opis="Meggle trajno mlijeko 3,2% m.m. karakterizira praktičnost i dugotrajna kvaliteta zahvaljujući navojnom čepu. S nešto manjim udjelom mliječnih masnoća, odgovarat će većini kupaca.", Fotografija="7fc7677e580ac3e7b8477ddd1f0ba7b9.png" },

new Proizvod {Barkod=387123456808,ProizvodjacID=4, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="SVJEŽE MLIJEKO 2,8 % m.m.", Opis="Ne odričite se prirodnog izvora kalcija iako živite u gradu ili nemate mogućnost posjedovanja vlastite kravice.", Fotografija="b9faf37be995e6dd0c571f2e046415c1.png" },

new Proizvod {Barkod=387123456809,ProizvodjacID=4, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="MLIJEKO BEZ LAKTOZE 1,5% m.m.", Opis="Svjesni smo da je oko 65% svjetske populacije u određenoj mjeri netolerantno na laktozu.", Fotografija="a6a9da4fb1e8a12c0c3eb3f96b0f788a.png" },

new Proizvod {Barkod=387123456809,ProizvodjacID=4, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="MEGGLE VAJKREM", Opis="Meggle mliječni namazi su proizvodi u kojima je satkana tradicija i najbolje od mlijeka. Lako mazivi s vašim omiljenim pecivom predstavljaju savršeni mliječni doručak. ", Fotografija="d3b92053914bed17b24f9d39a18c16ba.png" },

new Proizvod {Barkod=387123456810,ProizvodjacID=5, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="XICLAV", Opis="XICLAV® je antibiotik koji djeluje tako što uništava bakterije koje uzrokuju infekcije.", Fotografija="xiclav.jpg" },

new Proizvod {Barkod=387123456811,ProizvodjacID=5, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="PARACETAMOL", Opis="PARACETAMOL BOSNALIJEK tablete se primjenjuju za olakšanje glavobolje,tenzione glavobolje,migrene, bola u leđima, reumatskog bola i bola u mišićima, zubobolje i menstrualnog bola", Fotografija="paracetam.jpg" },

new Proizvod {Barkod=387123456812,ProizvodjacID=5, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="LOPRIL", Opis="Lijek LOPRIL tablete sadrži aktivnu supstancu lizinopril, koji pripada grupi lijekova koji se zovu ACE inhibitori (inhibitori angiotenzin konvertirajućeg enzima).", Fotografija="lopril.jpg" },

new Proizvod {Barkod=387123456813,ProizvodjacID=6, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="LED SIJALICA - 10 W", Opis="BP LED sijalice zrače toplo bijelo ili hladno bijelo svjetlo i donose svjetlost sa sjajnim efektom.", Fotografija="633x850 10w.jpg" },

new Proizvod {Barkod=387123456814,ProizvodjacID=6, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="VODOMJERNI ORMAR", Opis="Vodomjerni ormarići su namjenjeni za smještanje vodomjera za direktno fizičko i daljinsko očitanje vodomjera kod individualnih potrošača vode.", Fotografija="water-meter-cabinet.jpg" },

new Proizvod {Barkod=387123456815,ProizvodjacID=6, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="MJERNI ORMARI", Opis="Mjerni ormari MO-n su namijenjeni za direktno mjerenje utroška električne energije kod individualnih priključaka.", Fotografija="electro.jpg" },

new Proizvod {Barkod=387123456819,ProizvodjacID=8, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="HLJEB", Opis="Svježi pekarski proizvodi", Fotografija="hljeb.jpg" },

new Proizvod {Barkod=387123456820,ProizvodjacID=8, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Pšenično brašno", Opis="Klas proizvodi sve tipove brašna, T-400, T-500, T-710, T-850, T-1100.", Fotografija="140331013.jpg" },

new Proizvod {Barkod=387123456821,ProizvodjacID=8, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="KROFNE", Opis="Pekarski specijalitet.", Fotografija="krofna-sa-eurokremom.jpg" },

new Proizvod {Barkod=387123456822,ProizvodjacID=8, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Burek", Opis="Specijalitet bosanske kuhinje.", Fotografija="Burek-2.jpg" },

new Proizvod {Barkod=387123456823,ProizvodjacID=9, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="AurA Red premium", Opis="Ovu ediciju karakteriše spoj potpuno zaokruženih, istaknutih i prepoznatljivih pušačkih svojstava linije proizvoda AurA.", Fotografija="AR_P.png" },

new Proizvod {Barkod=387123456824,ProizvodjacID=9, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Drina gold", Opis="Lagana cigareta sa smanjenim sadržajem nikotina i katrana, lijepe arome i okusa.", Fotografija="DG.png" },

new Proizvod {Barkod=387123456825,ProizvodjacID=9, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Diva slims", Opis="Fabrika duhana Sarajevo je 2011. god. lansirala svoju prvu slims cigaretu – Diva slims.", Fotografija="Diva_web.png" },

new Proizvod {Barkod=387123456823,ProizvodjacID=10, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="ARIX Tenzo 21", Opis="Deterdžent stoljeća za mašinsko i ručno pranje veša.", Fotografija="arix.png" },

new Proizvod {Barkod=387123456823,ProizvodjacID=10, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="ARIX Tenzo 21", Opis="Deterdžent stoljeća za mašinsko i ručno pranje veša.", Fotografija="arix.png" },

new Proizvod {Barkod=387123456824,ProizvodjacID=10, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="IDA Limeta", Opis="Deterdžent idealnih karakteristika.", Fotografija="ida.png" },

new Proizvod {Barkod=387123456825,ProizvodjacID=10, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="3De", Opis="Tečni deterdžent za pranje posuđa.", Fotografija="3de.jpg" },

new Proizvod {Barkod=387123456826,ProizvodjacID=11, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Kuhinjska varena jodirana so", Opis="Kuhinjska varena jodirana so je jedan od rijetkih autohtonih bosanskohercegovačkih  proizvoda sa višestoljetnom  tradicijom i zavidnim nivoom kvaliteta.", Fotografija="Tuzlanska-so-1-kg.jpg" },

new Proizvod {Barkod=387123456827,ProizvodjacID=11, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Dijetalna so", Opis="Dijetalna so je proizvod sa sniženim sadržajem natrijuma i povećanim sadržajem kalijuma ali sa stručno definisanim omjerom", Fotografija="Dijetalna-so-100-i-250-g.jpg" },

new Proizvod {Barkod=387123456828,ProizvodjacID=11, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Industrijska varena nejodirana so", Opis="Visok nivo NaCi-a (cca. 99%), a samim tim i čistoća soli pogoduje korištenju u svim proizvodno-prerađivačkim industrijama.", Fotografija="Tabletirana-so-25-kg.jpg" },

new Proizvod {Barkod=387123456829,ProizvodjacID=12, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Ajvar ljuti", Opis="Uprženi ljuti ajvar", Fotografija="ajvarLJuti5.png" },

new Proizvod {Barkod=387123456830,ProizvodjacID=12, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Miješana salata", Opis="Kisela salata od miješanog povrća", Fotografija="mijesanaSalata4.png" },

new Proizvod {Barkod=387123456831,ProizvodjacID=12, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Džem šumsko voće", Opis="Džem napravljen od različitih vrsta šumskog voća", Fotografija="dzemSumsko.png" },

new Proizvod {Barkod=387123456831,ProizvodjacID=12, DatumObjave=DateTime.Parse("2015-5-5"),  Naziv="Nektar borovnice", Opis="Voćni sok napravljen od ekstrakta borovnice", Fotografija="sokicBorovnica-1.png" }

                    };
            proizvodi.ForEach(s => context.Proizvodi.Add(s));
            context.SaveChanges();

            var recenzije = new List<Recenzija>
            {
                new Recenzija {KorisnikID=2, ProizvodID=1, Tekst="Super Proizvod, volim domaće!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=2, ProizvodID=1, Tekst="Solidan proizvod,moze biti malo bolji! ", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },

new Recenzija {KorisnikID=3, ProizvodID=1, Tekst="Solidan proizvod!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=1, Tekst="Weeeeee!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=1, Tekst="Sta je ovo", Datum=DateTime.Parse("2015-5-5"), Ocjena=1 },

new Recenzija {KorisnikID=2, ProizvodID=1, Tekst="Razocarana sam", Datum=DateTime.Parse("2015-5-5"), Ocjena=2 },

new Recenzija {KorisnikID=3, ProizvodID=1, Tekst="Super,vozilo radi fenomenalno", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=4, ProizvodID=1, Tekst="Nije lose", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },

new Recenzija {KorisnikID=5, ProizvodID=1, Tekst="Super Proizvod, volim domaće!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=1, Tekst="Nice", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=1, Tekst="Raspad sistema", Datum=DateTime.Parse("2015-5-5"), Ocjena=2 },

new Recenzija {KorisnikID=3, ProizvodID=11, Tekst="Ne ledi vise!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=2, ProizvodID=5, Tekst="Dobar proizvod", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=6, Tekst="Solidno!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=13, Tekst="Super!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=3, ProizvodID=14, Tekst="Nema dalje! ", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=3, ProizvodID=15, Tekst="Eksluziva!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=18, Tekst="Odlicna mineralna!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=4, ProizvodID=16, Tekst="Dobro pivo!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=5, ProizvodID=17, Tekst="Moze proc!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=3, ProizvodID=19, Tekst="Casa vise bubreg manje!", Datum=DateTime.Parse("2015-5-5"), Ocjena=2 },

new Recenzija {KorisnikID=4, ProizvodID=22, Tekst="Odlicno!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=20, Tekst="Onako..", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },

new Recenzija {KorisnikID=2, ProizvodID=21, Tekst="Moze proc!", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=22, Tekst="nije lose", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=23, Tekst="dobra stvar", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=2, ProizvodID=24, Tekst="nije los lijek", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=24, Tekst="bezveze", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },

new Recenzija {KorisnikID=2, ProizvodID=25, Tekst="onako", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=3, ProizvodID=25, Tekst="dugotrajna!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=3, ProizvodID=26, Tekst="nije los", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=27, Tekst="jako precizno!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=28, Tekst="nije lose", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=28, Tekst="nako", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=4, ProizvodID=30, Tekst="super!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=3, ProizvodID=34, Tekst="Strava!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=2, ProizvodID=33, Tekst="il fenomeno", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=30, Tekst="super!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=3, ProizvodID=35, Tekst="Pusenje ubija !!!!!", Datum=DateTime.Parse("2015-5-5"), Ocjena=1 },

new Recenzija {KorisnikID=4, ProizvodID=38, Tekst="Odlican deterdzent!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=41, Tekst="Odlican proizvod!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=5, ProizvodID=40, Tekst="Super...", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=42, Tekst="Odlican proizvod!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 },

new Recenzija {KorisnikID=2, ProizvodID=43, Tekst="Moze proci.", Datum=DateTime.Parse("2015-5-5"), Ocjena=3 },

new Recenzija {KorisnikID=3, ProizvodID=44, Tekst="Super...", Datum=DateTime.Parse("2015-5-5"), Ocjena=4 },

new Recenzija {KorisnikID=2, ProizvodID=45, Tekst="Fenomealno!", Datum=DateTime.Parse("2015-5-5"), Ocjena=5 }

            };
            recenzije.ForEach(s => context.Recenzije.Add(s));
            context.SaveChanges();
        }

    }
}