using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak02.Models;

namespace Zadatak02.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Unos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uredi(string ime, string prezimme, string email, string status, Guid studentID)
        {
            foreach(StudentModel student in Repozitorij.studenti)
            {
                if(student.StudentID == studentID)
                {
                    student.ime = ime;
                    student.prezime = prezimme;
                    student.email = email;
                    student.status = status;
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Uredi(Guid StudentID)
        {
            foreach(StudentModel s in Repozitorij.studenti)
            {
                if(s.StudentID == StudentID)
                {
                    ViewBag.student = s;
                    return View();
                }
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Unos(string ime, string prezime, string email, string status)
        {
            if(ime == "" || prezime == "" || email == "")
            {
                return View("Error");
            }

            StudentModel model = new StudentModel();
            model.ime = ime;
            model.prezime = prezime;
            model.email = email;
            model.status = status;

            Repozitorij.DodajStudenta(model);

            return View("Potvrda", model);
        }

        public ActionResult PrikaziStudente()
        {
            ViewBag.studenti = Repozitorij.studenti;
            return View("PrikazStudenata");
        }
    }
}