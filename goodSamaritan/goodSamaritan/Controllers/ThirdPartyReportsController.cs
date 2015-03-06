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
    public class ThirdPartyReportsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: ThirdPartyReports
        public async Task<ActionResult> Index()
        {
            return View(await db.ThirdPartyReports.ToListAsync());
        }

        // GET: ThirdPartyReports/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReport thirdPartyReport = await db.ThirdPartyReports.FindAsync(id);
            if (thirdPartyReport == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReport);
        }

        // GET: ThirdPartyReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThirdPartyReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ThirdPartyReportId,Value")] ThirdPartyReport thirdPartyReport)
        {
            if (ModelState.IsValid)
            {
                db.ThirdPartyReports.Add(thirdPartyReport);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(thirdPartyReport);
        }

        // GET: ThirdPartyReports/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReport thirdPartyReport = await db.ThirdPartyReports.FindAsync(id);
            if (thirdPartyReport == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReport);
        }

        // POST: ThirdPartyReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ThirdPartyReportId,Value")] ThirdPartyReport thirdPartyReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thirdPartyReport).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(thirdPartyReport);
        }

        // GET: ThirdPartyReports/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThirdPartyReport thirdPartyReport = await db.ThirdPartyReports.FindAsync(id);
            if (thirdPartyReport == null)
            {
                return HttpNotFound();
            }
            return View(thirdPartyReport);
        }

        // POST: ThirdPartyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ThirdPartyReport thirdPartyReport = await db.ThirdPartyReports.FindAsync(id);
            db.ThirdPartyReports.Remove(thirdPartyReport);
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
