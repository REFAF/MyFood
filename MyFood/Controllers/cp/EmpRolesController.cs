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
    public class EmpRolesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmpRoles
        public ActionResult Index()
        {
            return View(db.EmpRoles.ToList());
        }

        // GET: EmpRoles/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpRole empRole = db.EmpRoles.Find(id);
            if (empRole == null)
            {
                return HttpNotFound();
            }
            return View(empRole);
        }

        // GET: EmpRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "role_id,role_name,note")] EmpRole empRole)
        {
            if (ModelState.IsValid)
            {
                db.EmpRoles.Add(empRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empRole);
        }

        // GET: EmpRoles/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpRole empRole = db.EmpRoles.Find(id);
            if (empRole == null)
            {
                return HttpNotFound();
            }
            return View(empRole);
        }

        // POST: EmpRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "role_id,role_name,note")] EmpRole empRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empRole);
        }

        // GET: EmpRoles/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpRole empRole = db.EmpRoles.Find(id);
            if (empRole == null)
            {
                return HttpNotFound();
            }
            return View(empRole);
        }

        // POST: EmpRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            EmpRole empRole = db.EmpRoles.Find(id);
            db.EmpRoles.Remove(empRole);
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
