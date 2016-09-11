using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vjezbe09.Models;

namespace Vjezbe09.Controllers
{
    public class KorijenController : Controller
    {
        // GET: Korijen
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Korijenuj(int a)
        {
            Rezultat rez = new Rezultat();
            rez.rezultat = Math.Sqrt(a);

            return View(rez);            
        }
    }
}