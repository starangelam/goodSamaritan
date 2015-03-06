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
    public class SocialWorkAttendancesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: SocialWorkAttendances
        public async Task<ActionResult> Index()
        {
            return View(await db.SocialWorkAttendances.ToListAsync());
        }

        // GET: SocialWorkAttendances/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = await db.SocialWorkAttendances.FindAsync(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialWorkAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SocialWorkAttendanceId,Value")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.SocialWorkAttendances.Add(socialWorkAttendance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = await db.SocialWorkAttendances.FindAsync(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SocialWorkAttendanceId,Value")] SocialWorkAttendance socialWorkAttendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialWorkAttendance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(socialWorkAttendance);
        }

        // GET: SocialWorkAttendances/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialWorkAttendance socialWorkAttendance = await db.SocialWorkAttendances.FindAsync(id);
            if (socialWorkAttendance == null)
            {
                return HttpNotFound();
            }
            return View(socialWorkAttendance);
        }

        // POST: SocialWorkAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SocialWorkAttendance socialWorkAttendance = await db.SocialWorkAttendances.FindAsync(id);
            db.SocialWorkAttendances.Remove(socialWorkAttendance);
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
