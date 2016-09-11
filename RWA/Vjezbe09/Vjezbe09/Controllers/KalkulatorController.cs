using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vjezbe09.Models;

namespace Vjezbe09.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: Kalkulator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KalkulatorIndex()
        {
            return View();
        }

        public ActionResult Racunaj(char operacija, int a, int b)
        {
            KalkulatorData data = new KalkulatorData();
            data.operacija = operacija;
            data.a = a;
            data.b = b;

            return RedirectToAction("KalkulatorResult", data);
        }

        public ActionResult KalkulatorResult(KalkulatorData data)
        {
            return View(data);
        }
    }
}