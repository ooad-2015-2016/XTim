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
using unirest_net;
using unirest_net.http;
using System.Threading.Tasks;

namespace Korpa387.Controllers
{
    public class quot
    {
         string quote { get; set; }
         string author { get; set; }
         string category { get; set; }
         string cat { get; set; }
    }
    public class ProizvodjacController : Controller
    {
        private Korpa387Context db = new Korpa387Context();

        // GET: Proizvodjac
        public ActionResult Index()
        {
            return View(db.Proizvodjaci.ToList());
        }

        // GET: Proizvodjac/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Proizvodjac");
            }
            Proizvodjac proizvodjac = db.Proizvodjaci.Find(id);
            if (proizvodjac == null)
            {
                return RedirectToAction("error404", "Home");
            }
            if(Session["LoggedUser"] != null && (String)Session["LoggedUserType"] == "productAdmin")
            {
                ViewBag.ID = (int)((Proizvodjac)Session["LoggedUser"]).ID;
            }
            else
            {
                ViewBag.ID = -1;
            }
            ViewBag.proizvodjac = proizvodjac;
            ViewBag.bp = proizvodjac.Proizvodi.Count;
            return View();
        }

        

       

        // GET: Proizvodjac/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvodjac proizvodjac = db.Proizvodjaci.Find(id);
            if (proizvodjac == null)
            {
                return HttpNotFound();
            }
            return View(proizvodjac);
        }

        // POST: Proizvodjac/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Naziv,Opis,Lokacija,Fotografija")] Proizvodjac proizvodjac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proizvodjac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proizvodjac);
        }

        // GET: Proizvodjac/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvodjac proizvodjac = db.Proizvodjaci.Find(id);
            if (proizvodjac == null)
            {
                return HttpNotFound();
            }
            return View(proizvodjac);
        }

        // POST: Proizvodjac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proizvodjac proizvodjac = db.Proizvodjaci.Find(id);
            db.Proizvodjaci.Remove(proizvodjac);
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
        [HttpPost]
        public ActionResult Pretraga(string pretraga)
        {
            pretraga = pretraga.ToLower();
            var proizvodjaci = db.Proizvodjaci.ToList();
            if(!String.IsNullOrEmpty(pretraga) && pretraga.Length < 32)
            {
                var svi = proizvodjaci.Where(s => s.Naziv.ToLower().Contains(pretraga));
                ViewBag.rezultati = svi;
                ViewBag.pojam = pretraga;
            }
            else if(pretraga.Length >= 32)
            {
                ViewBag.rezultati = proizvodjaci;
                ViewBag.pojam = "Predug pojam(max 32)";
            }
            else
            {
                ViewBag.rezultati = proizvodjaci;
                ViewBag.pojam = "";
            }
            return View();
        }
        public ActionResult Pretraga()
        {
            var proizvodjaci = db.Proizvodjaci.ToList();
            ViewBag.rezultati = proizvodjaci;
            ViewBag.pojamPretrage = "";
            return View();
        }

    }
}
