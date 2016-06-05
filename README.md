# XTim

X-Tim

ZA FINALNE INFORMACIJE SKROLAJTE DO KRAJA!

**Clanovi Tima:**

 - Belmin Mustajbasic
 - Kemal Halilbegovic
 - Benjamin Hrustemovic
 - Haris Halilovic

## Projekat: 387 Proizvodi
![Logo](http://i.imgur.com/VV8nEmX.png)

Svi smo svjesni opadanja BiH ekonomije zbog nedovoljnog interesa za naše vlastite proizvode. Strani proizvodi preplavljuju naše tržište, brojne domaće kompanije se gube u nijma. Razlog preferiranja stranih proizvoda kvalitet, nego ogromne količine promocija tih proizvoda. Često, mnogi građani BiH nisu ni svjesni koji su prizvodi domaći, a koji stranog porijekla, što je posljedica nedovoljne promocije naših, domaćih proizvoda. Upravo iz ovog razloga naš tim razvija projekat 387 Proizvodi. 
**387 Proizvodi** je platforma namijenjena kako potrošaćima da dobiju informacije o domaćim proizvodima tako i proizvođačima da unesu svoj proizvod te informacije o istom u bazu proizvoda. Uz pomoć ove platforme, proizvođaći domaćih proizvoda će dobiti priliku za promociju svojih prizvoda, a potrošaći će moći, bez ikakvih nedoumica, odlučiti se za korišenje domaćih prizvoda, i tako poboljšati našu nestabilnu ekonomiju. 

#### Procesi:
Registracija proizvodaca:
- Proizvodaci domacih proizvoda ce se moci registrovati, a administratori ce voditi racuna o tome da li se zapravo radi od domacem proizvodacu. Ako jeste, onda se u bazi podataka dodaje dati proizvodac, ako nije onda se nalog za unos u bazu ignoriše.

Dodavanje novih proizvoda/ažuriranje proizvoda:
- Omogucava registrovanim proizvodacima da svoj novi proizvod dodaju u bazu podataka, te da izvrše izmjene nad vec postojecim proizvodima.

Obavijesti:
- Korisnik(potrosac) ce uvijek biti obavješten pri pojavi novog proizvoda.

Dobivanje željenih informacija:
- Korisnik u svakom trenutku može dobiti informaciju koja ga interesuje, bilo vezana za proizvod ili proizvodaca.

Pretraga:
- Korisnici mogu pretraživati proizvode po kategorijama i nazivu.

#### Funkcionalnosti:
- Za administratora:
  - Pregledati sve registrovane prozivođače i proizvode
  - Uređivati sve registrovane proizvođače
  - Brisati proizvode i proizvođače
  - Slati newsletter svim preplatnicima
  - Dodavati obavijesti

- Za proizvođače:
  - Pregled vlastitih proizvoda
  - Uređivati vlastite proizvode
  - Brisati vlastite proizvode
  - Dodavati obavijesti
  - Pregledati recenzije svojih proizvoda
  - Odgovarati na pitanja
  - Podrska barcode scanneru

- Za registrovane korisnike:
  - Gledati katalog proizvoda i proizvođača
  - Pretraživati proizvode po kategorijama i nazivu
  - Ostavljati recenzije proizvodima
  - Uređivati svoj profil
  - Postavljati pitanja proizvođačima

- Za neregistrovane korisnike:
  - Gledati katalog proizvoda i proizvođača
  - Pretraživati proizvode po kategorijama i nazivu
  

 #### Akteri:
- Administrator
- Proizvođač
- Registrovani korisnik
- Neregistrovani korisnik

#Final
-VIDEO: https://www.youtube.com/watch?v=LRO7obiS5Oc

-Baza podataka : Lokalna / Entity 

-Eksterni uređaj : Korišten čitač magnetnih kartica koji je simulirao barkod čitač. Korišten za pretragu proizvda 

-Validacija : Najbolji primjer validacije je pri registraciji korisnika(Ime i prezime moraju biti duži od 6 karaktera, email ima regex vadilaciju i password mora biti duži od 5 karaktera) 

-Prilagođavanje UI-a : UI sa strane ASp dijela je prilagođen za sve ekrane , od velikih do malih, a UWP je prilagođen za mobilne uređaje.

-Web Servisi nisu korišteni.
