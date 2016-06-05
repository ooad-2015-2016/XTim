using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Korpa387.DAL;
using Korpa387.Models;
using System.Web.Script.Serialization;
using System.IO;

namespace Korpa387.Controllers
{
    public class JSONProizvod
    {
        string naziv { get; set; }
        string opis { get; set; }
        string proizvodjac { get; set; }
        int id { get; set; }
        long barkod { get; set; }
        int idproizvodjaca { get; set; }

        public JSONProizvod (string nnaziv, string oopis, string pproizvodjac, int iid, int iidproizvodjaca,long bbarkod)
        {
            naziv = nnaziv;
            opis = oopis;
            proizvodjac = pproizvodjac;
            id = iid;
            idproizvodjaca = iidproizvodjaca;
            barkod = bbarkod;
        }
        
    }
    public class ProizvodController : Controller
    {
        private Korpa387Context db = new Korpa387Context();

        // GET: Proizvod
        public ActionResult Index()
        {
            var proizvodi = db.Proizvodi.Include(p => p.Proizvodjac).ToList();
            ViewBag.proizvodi = proizvodi;
            return View();
        }

        

        public ActionResult Pretraga()
        {
            var proizvodi = db.Proizvodi.Include(p => p.Proizvodjac).ToList();
            ViewBag.proizvodi = proizvodi;
            return View();
        }

        [HttpPost]
        public ActionResult Pretraga(string pretraga)
        {
            pretraga = pretraga.ToLower();
            var proizvodi = db.Proizvodi.Include(p => p.Proizvodjac).ToList();
            if (!String.IsNullOrEmpty(pretraga) && pretraga.Length < 32)
            {
                var svi = proizvodi.Where(s => s.Naziv.ToLower().Contains(pretraga)).ToList();
                if(svi.Count==0)
                {
                    try
                    {
                        long bk = Convert.ToInt64(pretraga);
                        var jedan = proizvodi.Where(s => s.Barkod.Equals(bk)).ToList();
                        if(jedan.Count == 1)
                        {
                            return RedirectToAction("Details","Proizvod",new { id=jedan[0].ID });
                        }
                        ViewBag.proizvodi = jedan;
                    } catch (Exception e)
                    {
                        ViewBag.proizvodi = svi;
                        
                    }
                    
                }
                else
                {
                    ViewBag.proizvodi = svi;
                }
                
                ViewBag.pojam = pretraga;
            }
            else if (pretraga.Length >= 32)
            {
                ViewBag.proizvodi = proizvodi;
                ViewBag.pojam = "Predug pojam(max 32)";
            }
            else
            {
                ViewBag.proizvodi = proizvodi;
                ViewBag.pojam = "";
            }
            return View();
        }

        // GET: Proizvod/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Proizvod");
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                return RedirectToAction("error404", "Home");
            }
            if (Session["LoggedUser"] != null && ((string)Session["LoggedUserType"] == "productAdmin")) ViewBag.ID = ((Proizvodjac)Session["LoggedUser"]).ID;
            else ViewBag.ID = -1;
            ViewBag.proizvod = proizvod;
            int suma = 0;
            foreach(var rec in proizvod.Recenzije)
            {
                suma += rec.Ocjena;
            }

            var sverecenzije = db.Recenzije.Where(p => p.ProizvodID == id).ToList();
            var recenzije = new List<Recenzija>();
            if (sverecenzije.Count > 10)
            {
                for (int i = 1; i < 11; i++)
                {
                    recenzije.Add(sverecenzije[sverecenzije.Count - i]);
                }
                ViewBag.recenzije = recenzije;
                ViewBag.poruka = "Zadnjih 10 recenzija:";
            }
            else
            {
                for (int i = 1; i <= sverecenzije.Count; i++)
                {
                    recenzije.Add(sverecenzije[sverecenzije.Count - i]);
                }
                ViewBag.recenzije = recenzije;
                ViewBag.poruka = "Sve recenzije:";
            }


            if (suma==0) ViewBag.ocjena = 0;
            else ViewBag.ocjena = Math.Round((Decimal)((float)suma / proizvod.Recenzije.Count), 2);

            return View();
        }
        /*
        public ActionResult Rest(int? id)
        {
            if (id == null)
            {
                ViewBag.value = "null";
                return View();
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                ViewBag.value = "null";
                return View();
            }
            
            ViewBag.proizvod = proizvod;
            var ovo = new JSONProizvod(proizvod.Naziv, proizvod.Opis, proizvod.Proizvodjac.Naziv, proizvod.ID, proizvod.ProizvodjacID, proizvod.Barkod);
            ViewBag.value = new JavaScriptSerializer().Serialize(ovo);
            return View();

            
        }
        */
        [HttpPost]
        public ActionResult Details(int? id, string textareaRec, string ocjena)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Proizvod");
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                return RedirectToAction("error404", "Home");
            }
            if(Session["LoggedUser"] != null)
            {
                int idk = (int)((Korisnik)Session["LoggedUser"]).ID;
                int idp = (int)id;
                int ocj = Convert.ToInt32(ocjena);
                var rec = new Recenzija { KorisnikID = idk, ProizvodID = idp, Tekst = textareaRec, Datum = DateTime.Parse("2015-5-5"), Ocjena = ocj };
                db.Recenzije.Add(rec);
                db.SaveChanges();
                return RedirectToAction("Details", "Proizvod", new { id = id });
            }
            else
            {
                return RedirectToAction("Details", "Proizvod", new { id = id });
            }
            
        }

        // GET: Proizvod/Create
        public ActionResult Create()
        {
            if (Session["LoggedUser"] != null && (string)Session["LoggedUserType"] == "productAdmin") ViewBag.ProizvodjacID = 1;
            else
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        // POST: Proizvod/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string Naziv, string Opis, string Barkod)
        {
            string fotografija = "logo.png";
            
            if (Session["LoggedUser"] != null && (string)Session["LoggedUserType"] == "productAdmin")
            {
                long bk = Convert.ToInt64(Barkod);
                var noviPro = new Proizvod { Barkod = bk, ProizvodjacID = ((Proizvodjac)Session["LoggedUser"]).ID, Naziv = Naziv, Opis = Opis, DatumObjave = DateTime.Parse("2015-5-5"), Fotografija = fotografija };
                db.Proizvodi.Add(noviPro);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
            
        }

        // GET: Proizvod/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Proizvod");
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                return RedirectToAction("error404", "Home");
            }
            if(Session["LoggedUser"] != null && (string)Session["LoggedUserType"] == "productAdmin")
            {
                if(((Proizvodjac)Session["LoggedUser"]).ID == proizvod.ProizvodjacID)
                {
                    ViewBag.proizvod = proizvod;
                    return View(proizvod);
                }
                else
                {
                    return RedirectToAction("Details", "Proizvod", new { id=id });
                }
            }
            else
            {
                return RedirectToAction("Details", "Proizvod", new { id = id });
            }

        }

        // POST: Proizvod/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Barkod,ProizvodjacID,Naziv,Opis,DatumObjave,Fotografija")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proizvod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Proizvod");
            }
            return View(proizvod);
        }

        // GET: Proizvod/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                return HttpNotFound();
            }
            return View(proizvod);
        }

        // POST: Proizvod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proizvod proizvod = db.Proizvodi.Find(id);
            db.Proizvodi.Remove(proizvod);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
