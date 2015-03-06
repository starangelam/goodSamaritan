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
    public class ReferringHospitalsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ReferringHospitals
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferringHospitals.ToListAsync());
        }

        // GET: ReferringHospitals/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = await db.ReferringHospitals.FindAsync(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferringHospitals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferringHospitalId,Value")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.ReferringHospitals.Add(referringHospital);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referringHospital);
        }

        // GET: ReferringHospitals/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = await db.ReferringHospitals.FindAsync(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferringHospitalId,Value")] ReferringHospital referringHospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referringHospital).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referringHospital);
        }

        // GET: ReferringHospitals/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferringHospital referringHospital = await db.ReferringHospitals.FindAsync(id);
            if (referringHospital == null)
            {
                return HttpNotFound();
            }
            return View(referringHospital);
        }

        // POST: ReferringHospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferringHospital referringHospital = await db.ReferringHospitals.FindAsync(id);
            db.ReferringHospitals.Remove(referringHospital);
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
