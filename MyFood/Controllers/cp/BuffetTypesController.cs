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
    [Authorize(Roles = "رئيس فريق")]
    public class BuffetTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BuffetTypes
        public ActionResult Index()
        {
            return View(db.BuffetTypes.ToList());
        }

        // GET: BuffetTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuffetType buffetType = db.BuffetTypes.Find(id);
            if (buffetType == null)
            {
                return HttpNotFound();
            }
            return View(buffetType);
        }

        // GET: BuffetTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuffetTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "buffet_type_id,buffet_type_name")] BuffetType buffetType)
        {
            if (ModelState.IsValid)
            {
                db.BuffetTypes.Add(buffetType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buffetType);
        }

        // GET: BuffetTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuffetType buffetType = db.BuffetTypes.Find(id);
            if (buffetType == null)
            {
                return HttpNotFound();
            }
            return View(buffetType);
        }

        // POST: BuffetTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "buffet_type_id,buffet_type_name")] BuffetType buffetType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buffetType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buffetType);
        }

        // GET: BuffetTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuffetType buffetType = db.BuffetTypes.Find(id);
            if (buffetType == null)
            {
                return HttpNotFound();
            }
            return View(buffetType);
        }

        // POST: BuffetTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BuffetType buffetType = db.BuffetTypes.Find(id);
            db.BuffetTypes.Remove(buffetType);
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
