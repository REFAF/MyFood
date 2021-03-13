using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyFood.Models;

namespace MyFood.Controllers.cp
{
    public class NeighborhoodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Neighborhoods
        public ActionResult Index()
        {
            var neighborhoods = db.neighborhoods.Include(n => n.Direction);
            return View(neighborhoods.ToList());
        }

        // GET: Neighborhoods/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Neighborhood neighborhood = db.neighborhoods.Find(id);
            if (neighborhood == null)
            {
                return HttpNotFound();
            }
            return View(neighborhood);
        }

        // GET: Neighborhoods/Create
        public ActionResult Create()
        {
            ViewBag.direction_id = new SelectList(db.Directions, "direction_id", "direction_name");
            return View();
        }

        // POST: Neighborhoods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Neighborhood_id,Neighborhood_name,direction_id")] Neighborhood neighborhood)
        {
            if (ModelState.IsValid)
            {
                db.neighborhoods.Add(neighborhood);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.direction_id = new SelectList(db.Directions, "direction_id", "direction_name", neighborhood.direction_id);
            return View(neighborhood);
        }

        // GET: Neighborhoods/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Neighborhood neighborhood = db.neighborhoods.Find(id);
            if (neighborhood == null)
            {
                return HttpNotFound();
            }
            ViewBag.direction_id = new SelectList(db.Directions, "direction_id", "direction_name", neighborhood.direction_id);
            return View(neighborhood);
        }

        // POST: Neighborhoods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Neighborhood_id,Neighborhood_name,direction_id")] Neighborhood neighborhood)
        {
            if (ModelState.IsValid)
            {
                db.Entry(neighborhood).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.direction_id = new SelectList(db.Directions, "direction_id", "direction_name", neighborhood.direction_id);
            return View(neighborhood);
        }

        // GET: Neighborhoods/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Neighborhood neighborhood = db.neighborhoods.Find(id);
            if (neighborhood == null)
            {
                return HttpNotFound();
            }
            return View(neighborhood);
        }

        // POST: Neighborhoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            Neighborhood neighborhood = db.neighborhoods.Find(id);
            db.neighborhoods.Remove(neighborhood);
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
