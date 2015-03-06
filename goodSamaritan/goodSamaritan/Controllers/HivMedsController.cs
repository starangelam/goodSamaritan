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
    public class HivMedsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: HivMeds
        public async Task<ActionResult> Index()
        {
            return View(await db.HivMeds.ToListAsync());
        }

        // GET: HivMeds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HivMeds hivMeds = await db.HivMeds.FindAsync(id);
            if (hivMeds == null)
            {
                return HttpNotFound();
            }
            return View(hivMeds);
        }

        // GET: HivMeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HivMeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "HivMedsId,Value")] HivMeds hivMeds)
        {
            if (ModelState.IsValid)
            {
                db.HivMeds.Add(hivMeds);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hivMeds);
        }

        // GET: HivMeds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HivMeds hivMeds = await db.HivMeds.FindAsync(id);
            if (hivMeds == null)
            {
                return HttpNotFound();
            }
            return View(hivMeds);
        }

        // POST: HivMeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "HivMedsId,Value")] HivMeds hivMeds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hivMeds).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hivMeds);
        }

        // GET: HivMeds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HivMeds hivMeds = await db.HivMeds.FindAsync(id);
            if (hivMeds == null)
            {
                return HttpNotFound();
            }
            return View(hivMeds);
        }

        // POST: HivMeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HivMeds hivMeds = await db.HivMeds.FindAsync(id);
            db.HivMeds.Remove(hivMeds);
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
