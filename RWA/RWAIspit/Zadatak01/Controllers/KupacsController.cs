using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zadatak01;

namespace Zadatak01.Controllers
{
    public class KupacsController : Controller
    {
        private AdventureWorksOBPEntities db = new AdventureWorksOBPEntities();

        // GET: Kupacs
        public ActionResult Index(int? id)
        {
            var kupacs = db.Kupacs.Include(k => k.Grad);
            ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv");
            if (id != null)
            {
                kupacs = kupacs.Where(k => k.GradID == id);
                ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv", id);
            }
            kupacs = kupacs.Take(6);
            return View(kupacs.ToList());
        }

        // GET: Kupacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupac kupac = db.Kupacs.Find(id);
            if (kupac == null)
            {
                return HttpNotFound();
            }
            return View(kupac);
        }

        // GET: Kupacs/Create
        public ActionResult Create()
        {
            ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv");
            return View();
        }

        // POST: Kupacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDKupac,Ime,Prezime,Email,Telefon,GradID")] Kupac kupac)
        {
            if (ModelState.IsValid)
            {
                db.Kupacs.Add(kupac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv", kupac.GradID);
            return View(kupac);
        }

        // GET: Kupacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupac kupac = db.Kupacs.Find(id);
            if (kupac == null)
            {
                return HttpNotFound();
            }
            ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv", kupac.GradID);
            return View(kupac);
        }

        // POST: Kupacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDKupac,Ime,Prezime,Email,Telefon,GradID")] Kupac kupac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kupac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GradID = new SelectList(db.Grads, "IDGrad", "Naziv", kupac.GradID);
            return View(kupac);
        }

        // GET: Kupacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kupac kupac = db.Kupacs.Find(id);
            if (kupac == null)
            {
                return HttpNotFound();
            }
            return View(kupac);
        }

        // POST: Kupacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kupac kupac = db.Kupacs.Find(id);
            db.Kupacs.Remove(kupac);
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
