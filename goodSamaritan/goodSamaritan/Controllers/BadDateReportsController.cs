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
    public class BadDateReportsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: BadDateReports
        public async Task<ActionResult> Index()
        {
            return View(await db.BadDateReports.ToListAsync());
        }

        // GET: BadDateReports/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = await db.BadDateReports.FindAsync(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // GET: BadDateReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BadDateReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BadDateReportId,IsBadDateReported")] BadDateReport badDateReport)
        {
            if (ModelState.IsValid)
            {
                db.BadDateReports.Add(badDateReport);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(badDateReport);
        }

        // GET: BadDateReports/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = await db.BadDateReports.FindAsync(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // POST: BadDateReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BadDateReportId,IsBadDateReported")] BadDateReport badDateReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badDateReport).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(badDateReport);
        }

        // GET: BadDateReports/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadDateReport badDateReport = await db.BadDateReports.FindAsync(id);
            if (badDateReport == null)
            {
                return HttpNotFound();
            }
            return View(badDateReport);
        }

        // POST: BadDateReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BadDateReport badDateReport = await db.BadDateReports.FindAsync(id);
            db.BadDateReports.Remove(badDateReport);
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
