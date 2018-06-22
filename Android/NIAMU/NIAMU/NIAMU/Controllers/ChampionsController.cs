using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using NIAMU.Models;

namespace NIAMU.Controllers
{
    public class ChampionsController : ApiController
    {
        private ChampionsModel db = new ChampionsModel();

        // GET: api/Champions
        public IQueryable<Champions> GetChampions()
        {
            return db.Champions;
        }

        // GET: api/Champions/5
        [ResponseType(typeof(Champions))]
        public IHttpActionResult GetChampions(int id)
        {
            Champions champions = db.Champions.Find(id);
            if (champions == null)
            {
                return NotFound();
            }

            return Ok(champions);
        }

        // PUT: api/Champions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChampions(int id, Champions champions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != champions.ID)
            {
                return BadRequest();
            }

            db.Entry(champions).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Champions
        [ResponseType(typeof(Champions))]
        public IHttpActionResult PostChampions(Champions champions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Champions.Add(champions);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = champions.ID }, champions);
        }

        // DELETE: api/Champions/5
        [ResponseType(typeof(Champions))]
        public IHttpActionResult DeleteChampions(int id)
        {
            Champions champions = db.Champions.Find(id);
            if (champions == null)
            {
                return NotFound();
            }

            db.Champions.Remove(champions);
            db.SaveChanges();

            return Ok(champions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChampionsExists(int id)
        {
            return db.Champions.Count(e => e.ID == id) > 0;
        }

    }
}