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
    [Authorize(Roles = "Administrator")]
    public class HospitalAttendedsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: HospitalAttendeds
        public async Task<ActionResult> Index()
        {
            return View(await db.HospitalsAttended.ToListAsync());
        }

        // GET: HospitalAttendeds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = await db.HospitalsAttended.FindAsync(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalAttendeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "HospitalAttendedId,Value")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.HospitalsAttended.Add(hospitalAttended);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = await db.HospitalsAttended.FindAsync(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "HospitalAttendedId,Value")] HospitalAttended hospitalAttended)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalAttended).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hospitalAttended);
        }

        // GET: HospitalAttendeds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalAttended hospitalAttended = await db.HospitalsAttended.FindAsync(id);
            if (hospitalAttended == null)
            {
                return HttpNotFound();
            }
            return View(hospitalAttended);
        }

        // POST: HospitalAttendeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HospitalAttended hospitalAttended = await db.HospitalsAttended.FindAsync(id);
            db.HospitalsAttended.Remove(hospitalAttended);
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
