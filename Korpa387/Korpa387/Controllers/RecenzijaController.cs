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
    public class RecenzijaController : Controller
    {
        private Korpa387Context db = new Korpa387Context();

        // GET: Recenzija
        public ActionResult Index()
        {
            var recenzije = db.Recenzije.Include(r => r.Korisnik).Include(r => r.Proizvod);
            return View(recenzije.ToList());
        }

        // GET: Recenzija/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recenzija recenzija = db.Recenzije.Find(id);
            if (recenzija == null)
            {
                return HttpNotFound();
            }
            return View(recenzija);
        }

        // GET: Recenzija/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikID = new SelectList(db.Korisnici, "ID", "ImePrezime");
            ViewBag.ProizvodID = new SelectList(db.Proizvodi, "ID", "Naziv");
            return View();
        }

        // POST: Recenzija/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,KorisnikID,ProizvodID,Tekst,Datum,Ocjena")] Recenzija recenzija)
        {
            if (ModelState.IsValid)
            {
                db.Recenzije.Add(recenzija);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KorisnikID = new SelectList(db.Korisnici, "ID", "ImePrezime", recenzija.KorisnikID);
            ViewBag.ProizvodID = new SelectList(db.Proizvodi, "ID", "Naziv", recenzija.ProizvodID);
            return View(recenzija);
        }

        // GET: Recenzija/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recenzija recenzija = db.Recenzije.Find(id);
            if (recenzija == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikID = new SelectList(db.Korisnici, "ID", "ImePrezime", recenzija.KorisnikID);
            ViewBag.ProizvodID = new SelectList(db.Proizvodi, "ID", "Naziv", recenzija.ProizvodID);
            return View(recenzija);
        }

        // POST: Recenzija/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,KorisnikID,ProizvodID,Tekst,Datum,Ocjena")] Recenzija recenzija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recenzija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikID = new SelectList(db.Korisnici, "ID", "ImePrezime", recenzija.KorisnikID);
            ViewBag.ProizvodID = new SelectList(db.Proizvodi, "ID", "Naziv", recenzija.ProizvodID);
            return View(recenzija);
        }

        // GET: Recenzija/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recenzija recenzija = db.Recenzije.Find(id);
            if (recenzija == null)
            {
                return HttpNotFound();
            }
            return View(recenzija);
        }

        // POST: Recenzija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recenzija recenzija = db.Recenzije.Find(id);
            db.Recenzije.Remove(recenzija);
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
