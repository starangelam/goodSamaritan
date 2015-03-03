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
    public class VictimsOfIncidentsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: VictimsOfIncidents
        public ActionResult Index()
        {
            return View(db.VictimsOfIncidents.ToList());
        }

        // GET: VictimsOfIncidents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimsOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // GET: VictimsOfIncidents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimsOfIncidents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VictimOfIncidentId,Type")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.VictimsOfIncidents.Add(victimOfIncident);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victimOfIncident);
        }

        // GET: VictimsOfIncidents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimsOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimsOfIncidents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VictimOfIncidentId,Type")] VictimOfIncident victimOfIncident)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimOfIncident).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(victimOfIncident);
        }

        // GET: VictimsOfIncidents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimOfIncident victimOfIncident = db.VictimsOfIncidents.Find(id);
            if (victimOfIncident == null)
            {
                return HttpNotFound();
            }
            return View(victimOfIncident);
        }

        // POST: VictimsOfIncidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VictimOfIncident victimOfIncident = db.VictimsOfIncidents.Find(id);
            db.VictimsOfIncidents.Remove(victimOfIncident);
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
