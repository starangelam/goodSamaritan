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
    public class VictimServicesAttendancesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: VictimServicesAttendances
        public async Task<ActionResult> Index()
        {
            return View(await db.VictimServicesAttendances.ToListAsync());
        }

        // GET: VictimServicesAttendances/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendance victimServicesAttendance = await db.VictimServicesAttendances.FindAsync(id);
            if (victimServicesAttendance == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendance);
        }

        // GET: VictimServicesAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VictimServicesAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VictimServicesAttendanceId,Value")] VictimServicesAttendance victimServicesAttendance)
        {
            if (ModelState.IsValid)
            {
                db.VictimServicesAttendances.Add(victimServicesAttendance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(victimServicesAttendance);
        }

        // GET: VictimServicesAttendances/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendance victimServicesAttendance = await db.VictimServicesAttendances.FindAsync(id);
            if (victimServicesAttendance == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendance);
        }

        // POST: VictimServicesAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VictimServicesAttendanceId,Value")] VictimServicesAttendance victimServicesAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victimServicesAttendance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(victimServicesAttendance);
        }

        // GET: VictimServicesAttendances/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VictimServicesAttendance victimServicesAttendance = await db.VictimServicesAttendances.FindAsync(id);
            if (victimServicesAttendance == null)
            {
                return HttpNotFound();
            }
            return View(victimServicesAttendance);
        }

        // POST: VictimServicesAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VictimServicesAttendance victimServicesAttendance = await db.VictimServicesAttendances.FindAsync(id);
            db.VictimServicesAttendances.Remove(victimServicesAttendance);
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
