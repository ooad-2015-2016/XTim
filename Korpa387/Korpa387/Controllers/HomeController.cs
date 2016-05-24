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
    public class HomeController : Controller
    {
        private Korpa387Context db = new Korpa387Context();
        public ActionResult Index()
        {
            var proizvodi = db.Proizvodi.Include(p => p.Proizvodjac);
            var proizvodjaci = db.Proizvodjaci.ToList();
            var svi = proizvodi.ToList();
            var prvih7 = new List<Proizvod>();
            for(int i = 0; i<7; i++)
            {
                prvih7.Add(svi[i]);
            }
            ViewBag.proizvodi = prvih7;
            ViewBag.najbolji = prvih7;
            ViewBag.proizvodjaci = proizvodjaci;
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.err = "";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            var korisnici = db.Korisnici.Where(p=>p.Email == email).ToList();
            var err = "";
            if(korisnici.Count != 1)
            {
                err = "Neispravan email";
            }
            else
            {
                if(korisnici[0].Password != password)
                {
                    err = "Neispravna lozinka";
                }
                else
                {
                    Session["LoggedUser"] = korisnici[0];
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.err = err;
            return View();
        }
        public ActionResult LogOff()
        {
            Session["LoggedUser"] = null;
            return RedirectToAction("Login", "Home");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}