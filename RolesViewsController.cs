using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HealthAW.Models;
using TaskA.Models;

namespace HealthAW.Controllers
{
    public class RolesViewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RolesViews
        public ActionResult Index()
        {
            return View(db.RolesViews.ToList());
        }

        // GET: RolesViews/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesView rolesView = db.RolesViews.Find(id);
            if (rolesView == null)
            {
                return HttpNotFound();
            }
            return View(rolesView);
        }

        // GET: RolesViews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolesViews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleId,Name")] RolesView rolesView)
        {
            if (ModelState.IsValid)
            {
                db.RolesViews.Add(rolesView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rolesView);
        }

        // GET: RolesViews/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesView rolesView = db.RolesViews.Find(id);
            if (rolesView == null)
            {
                return HttpNotFound();
            }
            return View(rolesView);
        }

        // POST: RolesViews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleId,Name")] RolesView rolesView)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rolesView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rolesView);
        }

        // GET: RolesViews/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesView rolesView = db.RolesViews.Find(id);
            if (rolesView == null)
            {
                return HttpNotFound();
            }
            return View(rolesView);
        }

        // POST: RolesViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RolesView rolesView = db.RolesViews.Find(id);
            db.RolesViews.Remove(rolesView);
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
