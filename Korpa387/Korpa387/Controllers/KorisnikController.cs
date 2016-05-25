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

namespace Korpa387.Controllers
{
    public class KorisnikController : Controller
    {
        private Korpa387Context db = new Korpa387Context();

        // GET: Korisniks
        public ActionResult Index()
        {
            return View(db.Korisnici.ToList());
        }

        // GET: Korisniks/Details/5
        public ActionResult Details(int? id)
        {
            
            if (id == null)
            {
                if (Session["LoggedUser"] != null)
                {
                    id = ((Korisnik)Session["LoggedUser"]).ID;
                }
                else return RedirectToAction("Index", "Home");
            }
            ViewBag.id = id;
            
            Korisnik korisnik = db.Korisnici.Find(id);
            if (korisnik == null || korisnik.Role == 0)
            {
                return RedirectToAction("error404", "Home");
            }
            var sverecenzije = db.Recenzije.Where(p => p.KorisnikID == id).ToList();
            var recenzije = new List<Recenzija>();
            if(sverecenzije.Count > 10)
            {
                for (int i = 1; i < 11; i++)
                {
                    recenzije.Add(sverecenzije[sverecenzije.Count - i]);
                }
                ViewBag.recenzije = recenzije;
                ViewBag.poruka = "Zadnjih 10 recenzija:";
            } else
            {
                for (int i = 1; i <= sverecenzije.Count; i++)
                {
                    recenzije.Add(sverecenzije[sverecenzije.Count - i]);
                }
                ViewBag.recenzije = recenzije;
                ViewBag.poruka = "Sve recenzije:";
            }
            
            
            return View(korisnik);
        }

        // GET: Korisniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Korisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ImePrezime,Email,Password,Fotografija,Role")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Korisnici.Add(korisnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(korisnik);
        }

        // GET: Korisniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnici.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ImePrezime,Email,Password,Fotografija,Role")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korisnik);
        }

        // GET: Korisniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnici.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Korisnik korisnik = db.Korisnici.Find(id);
            db.Korisnici.Remove(korisnik);
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
