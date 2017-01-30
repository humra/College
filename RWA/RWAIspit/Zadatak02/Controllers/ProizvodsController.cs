using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zadatak02;

namespace Zadatak02.Controllers
{
    public class ProizvodsController : Controller
    {
        private AdventureWorksOBPEntities db = new AdventureWorksOBPEntities();

        // GET: Proizvods
        public ActionResult Index(int? kategorijaID, int? potkategorijaID)
        {
            ViewBag.KategorijaID = new SelectList(db.Kategorijas, "IDKategorija", "Naziv");

            if(kategorijaID != null)
            {
                ViewBag.KategorijaID = new SelectList(db.Kategorijas, "IDKategorija", "Naziv", kategorijaID);

                ViewBag.PotkategorijaID = new SelectList(db.Potkategorijas.Where(pk => pk.KategorijaID == kategorijaID), "IDPotkategorija", "Naziv");
            }

            if(potkategorijaID != null)
            {
                var proizvods = db.Proizvods.Where(p => p.PotkategorijaID == potkategorijaID);
                return View(proizvods.ToList());
            }

            //var proizvods = db.Proizvods.Include(p => p.Potkategorija);
            return View();
        }

        // GET: Proizvods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod proizvod = db.Proizvods.Find(id);
            if (proizvod == null)
            {
                return HttpNotFound();
            }
            return View(proizvod);
        }

        // GET: Proizvods/Create
        public ActionResult Create()
        {
            ViewBag.PotkategorijaID = new SelectList(db.Potkategorijas, "IDPotkategorija", "Naziv");
            return View();
        }

        // POST: Proizvods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDProizvod,Naziv,BrojProizvoda,Boja,MinimalnaKolicinaNaSkladistu,CijenaBezPDV,PotkategorijaID")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Proizvods.Add(proizvod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PotkategorijaID = new SelectList(db.Potkategorijas, "IDPotkategorija", "Naziv", proizvod.PotkategorijaID);
            return View(proizvod);
        }

        // GET: Proizvods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod proizvod = db.Proizvods.Find(id);
            if (proizvod == null)
            {
                return HttpNotFound();
            }
            ViewBag.PotkategorijaID = new SelectList(db.Potkategorijas, "IDPotkategorija", "Naziv", proizvod.PotkategorijaID);
            return View(proizvod);
        }

        // POST: Proizvods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDProizvod,Naziv,BrojProizvoda,Boja,MinimalnaKolicinaNaSkladistu,CijenaBezPDV,PotkategorijaID")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proizvod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PotkategorijaID = new SelectList(db.Potkategorijas, "IDPotkategorija", "Naziv", proizvod.PotkategorijaID);
            return View(proizvod);
        }

        // GET: Proizvods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod proizvod = db.Proizvods.Find(id);
            if (proizvod == null)
            {
                return HttpNotFound();
            }
            return View(proizvod);
        }

        // POST: Proizvods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proizvod proizvod = db.Proizvods.Find(id);
            db.Proizvods.Remove(proizvod);
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
