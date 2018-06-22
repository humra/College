using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NIAMU.Models;

namespace NIAMU.Controllers
{
    public class HomeController : Controller
    {
        private ChampionsModel db = new ChampionsModel();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Champions()
        {
            ViewData.Model = db.Champions;
            return View("~/Views/Home/Champions.cshtml");
        }
    }
}