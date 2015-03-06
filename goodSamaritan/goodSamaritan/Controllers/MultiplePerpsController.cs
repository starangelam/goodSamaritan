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
    public class MultiplePerpsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: MultiplePerps
        public async Task<ActionResult> Index()
        {
            return View(await db.MultiplePerps.ToListAsync());
        }

        // GET: MultiplePerps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerps multiplePerps = await db.MultiplePerps.FindAsync(id);
            if (multiplePerps == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerps);
        }

        // GET: MultiplePerps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultiplePerps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MultiplePerpsId,Value")] MultiplePerps multiplePerps)
        {
            if (ModelState.IsValid)
            {
                db.MultiplePerps.Add(multiplePerps);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(multiplePerps);
        }

        // GET: MultiplePerps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerps multiplePerps = await db.MultiplePerps.FindAsync(id);
            if (multiplePerps == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerps);
        }

        // POST: MultiplePerps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MultiplePerpsId,Value")] MultiplePerps multiplePerps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multiplePerps).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(multiplePerps);
        }

        // GET: MultiplePerps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiplePerps multiplePerps = await db.MultiplePerps.FindAsync(id);
            if (multiplePerps == null)
            {
                return HttpNotFound();
            }
            return View(multiplePerps);
        }

        // POST: MultiplePerps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MultiplePerps multiplePerps = await db.MultiplePerps.FindAsync(id);
            db.MultiplePerps.Remove(multiplePerps);
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
