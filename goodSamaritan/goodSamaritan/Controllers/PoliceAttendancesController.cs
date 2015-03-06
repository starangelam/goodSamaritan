using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodSamaritan.Models.Smart;
using goodSamaritan.Models.Client;

namespace GoodSamaritan.Controllers
{
    public class PoliceAttendancesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: PoliceAttendances
        public async Task<ActionResult> Index()
        {
            return View(await db.PoliceAttendances.ToListAsync());
        }

        // GET: PoliceAttendances/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendance policeAttendance = await db.PoliceAttendances.FindAsync(id);
            if (policeAttendance == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendance);
        }

        // GET: PoliceAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PoliceAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PoliceAttendanceId,Value")] PoliceAttendance policeAttendance)
        {
            if (ModelState.IsValid)
            {
                db.PoliceAttendances.Add(policeAttendance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(policeAttendance);
        }

        // GET: PoliceAttendances/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendance policeAttendance = await db.PoliceAttendances.FindAsync(id);
            if (policeAttendance == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendance);
        }

        // POST: PoliceAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PoliceAttendanceId,Value")] PoliceAttendance policeAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeAttendance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(policeAttendance);
        }

        // GET: PoliceAttendances/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceAttendance policeAttendance = await db.PoliceAttendances.FindAsync(id);
            if (policeAttendance == null)
            {
                return HttpNotFound();
            }
            return View(policeAttendance);
        }

        // POST: PoliceAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PoliceAttendance policeAttendance = await db.PoliceAttendances.FindAsync(id);
            db.PoliceAttendances.Remove(policeAttendance);
            await db.SaveChangesAsync();
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
