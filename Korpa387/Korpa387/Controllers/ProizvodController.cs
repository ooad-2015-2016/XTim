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
                var svi = proizvodi.Where(s => s.Naziv.ToLower().Contains(pretraga));
                ViewBag.proizvodi = svi;
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
            if(suma==0) ViewBag.ocjena = 0;
            else ViewBag.ocjena = Math.Round((Decimal)((float)suma / proizvod.Recenzije.Count), 2);

            return View();
        }

        // GET: Proizvod/Create
        public ActionResult Create()
        {
            ViewBag.ProizvodjacID = new SelectList(db.Proizvodjaci, "ID", "Naziv");
            return View();
        }

        // POST: Proizvod/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProizvodjacID,Naziv,Opis,DatumObjave,Fotografija")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Proizvodi.Add(proizvod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProizvodjacID = new SelectList(db.Proizvodjaci, "ID", "Naziv", proizvod.ProizvodjacID);
            return View(proizvod);
        }

        // GET: Proizvod/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.ProizvodjacID = new SelectList(db.Proizvodjaci, "ID", "Naziv", proizvod.ProizvodjacID);
            return View(proizvod);
        }

        // POST: Proizvod/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProizvodjacID,Naziv,Opis,DatumObjave,Fotografija")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proizvod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProizvodjacID = new SelectList(db.Proizvodjaci, "ID", "Naziv", proizvod.ProizvodjacID);
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
