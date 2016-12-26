using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak01.Models;

namespace Zadatak01.Controllers
{
    public class PrijavaController : Controller
    {
        // GET: Prijava
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Prijava()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Prijava(string ime, string prezime, string dolazak, string laptop)
        {
            StudentModel model = new StudentModel();
            model.ime = ime;
            model.prezime = prezime;
            model.dolazak = dolazak;
            model.laptop = laptop;

            return View("Potvrda", model);
        }
    }
}