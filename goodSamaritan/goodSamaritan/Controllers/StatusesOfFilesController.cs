using System;
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
    public class StatusesOfFilesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: StatusesOfFiles
        public ActionResult Index()
        {
            return View(db.StatusesOfFiles.ToList());
        }

        // GET: StatusesOfFiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusesOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // GET: StatusesOfFiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusesOfFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.StatusesOfFiles.Add(statusOfFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statusOfFile);
        }

        // GET: StatusesOfFiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusesOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusesOfFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatusOfFileId,Status")] StatusOfFile statusOfFile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusOfFile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statusOfFile);
        }

        // GET: StatusesOfFiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusOfFile statusOfFile = db.StatusesOfFiles.Find(id);
            if (statusOfFile == null)
            {
                return HttpNotFound();
            }
            return View(statusOfFile);
        }

        // POST: StatusesOfFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatusOfFile statusOfFile = db.StatusesOfFiles.Find(id);
            db.StatusesOfFiles.Remove(statusOfFile);
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
