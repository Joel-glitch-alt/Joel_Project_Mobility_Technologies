﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class EmpsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Emps
        public ActionResult Index()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }

        // GET: Emps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Emp emp = db.Employees.Find(id);

            if (emp == null)
            {
                return HttpNotFound();
            }

            return View(emp);
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,age,gender,address,course,language")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Emp emp = db.Employees.Find(id);

            if (emp == null)
            {
                return HttpNotFound();
            }

            return View(emp);
        }

        // POST: Emps/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,age,gender,address,course,language")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Emp emp = db.Employees.Find(id);

            if (emp == null)
            {
                return HttpNotFound();
            }

            return View(emp);
        }

        // POST: Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emp emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
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
