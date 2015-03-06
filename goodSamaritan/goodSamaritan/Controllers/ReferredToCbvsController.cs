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
    public class ReferredToCbvsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ReferredToCbvs
        public async Task<ActionResult> Index()
        {
            return View(await db.ReferredToCbvs.ToListAsync());
        }

        // GET: ReferredToCbvs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCbvs referredToCbvs = await db.ReferredToCbvs.FindAsync(id);
            if (referredToCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredToCbvs);
        }

        // GET: ReferredToCbvs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReferredToCbvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ReferredToCbvsId,Value")] ReferredToCbvs referredToCbvs)
        {
            if (ModelState.IsValid)
            {
                db.ReferredToCbvs.Add(referredToCbvs);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(referredToCbvs);
        }

        // GET: ReferredToCbvs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCbvs referredToCbvs = await db.ReferredToCbvs.FindAsync(id);
            if (referredToCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredToCbvs);
        }

        // POST: ReferredToCbvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ReferredToCbvsId,Value")] ReferredToCbvs referredToCbvs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referredToCbvs).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(referredToCbvs);
        }

        // GET: ReferredToCbvs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReferredToCbvs referredToCbvs = await db.ReferredToCbvs.FindAsync(id);
            if (referredToCbvs == null)
            {
                return HttpNotFound();
            }
            return View(referredToCbvs);
        }

        // POST: ReferredToCbvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ReferredToCbvs referredToCbvs = await db.ReferredToCbvs.FindAsync(id);
            db.ReferredToCbvs.Remove(referredToCbvs);
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
