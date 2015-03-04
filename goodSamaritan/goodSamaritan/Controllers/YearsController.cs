﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using goodSamaritan.Models.Client;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class YearsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Years
        public ActionResult Index()
        {
            return View(db.Years.ToList());
        }

        // GET: Years/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Year year = db.Years.Find(id);
            if (year == null)
            {
                return HttpNotFound();
            }
            return View(year);
        }

        // GET: Years/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Years/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YearId,Range")] Year year)
        {
            if (ModelState.IsValid)
            {
                db.Years.Add(year);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(year);
        }

        // GET: Years/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Year year = db.Years.Find(id);
            if (year == null)
            {
                return HttpNotFound();
            }
            return View(year);
        }

        // POST: Years/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YearId,Range")] Year year)
        {
            if (ModelState.IsValid)
            {
                db.Entry(year).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(year);
        }

        // GET: Years/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Year year = db.Years.Find(id);
            if (year == null)
            {
                return HttpNotFound();
            }
            return View(year);
        }

        // POST: Years/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Year year = db.Years.Find(id);
            db.Years.Remove(year);
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
