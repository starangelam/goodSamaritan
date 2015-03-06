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
    public class DrugFacilitatedsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: DrugFacilitateds
        public async Task<ActionResult> Index()
        {
            return View(await db.DrugsFacilitated.ToListAsync());
        }

        // GET: DrugFacilitateds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitated drugFacilitated = await db.DrugsFacilitated.FindAsync(id);
            if (drugFacilitated == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitated);
        }

        // GET: DrugFacilitateds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugFacilitateds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DrugFacilitatedId,Value")] DrugFacilitated drugFacilitated)
        {
            if (ModelState.IsValid)
            {
                db.DrugsFacilitated.Add(drugFacilitated);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(drugFacilitated);
        }

        // GET: DrugFacilitateds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitated drugFacilitated = await db.DrugsFacilitated.FindAsync(id);
            if (drugFacilitated == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitated);
        }

        // POST: DrugFacilitateds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DrugFacilitatedId,Value")] DrugFacilitated drugFacilitated)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drugFacilitated).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(drugFacilitated);
        }

        // GET: DrugFacilitateds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DrugFacilitated drugFacilitated = await db.DrugsFacilitated.FindAsync(id);
            if (drugFacilitated == null)
            {
                return HttpNotFound();
            }
            return View(drugFacilitated);
        }

        // POST: DrugFacilitateds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DrugFacilitated drugFacilitated = await db.DrugsFacilitated.FindAsync(id);
            db.DrugsFacilitated.Remove(drugFacilitated);
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
