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
    public class MedicalOnliesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: MedicalOnlies
        public async Task<ActionResult> Index()
        {
            return View(await db.MedicalOnly.ToListAsync());
        }

        // GET: MedicalOnlies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = await db.MedicalOnly.FindAsync(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalOnlies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MedicalOnlyId,Value")] MedicalOnly medicalOnly)
        {
            if (ModelState.IsValid)
            {
                db.MedicalOnly.Add(medicalOnly);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = await db.MedicalOnly.FindAsync(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // POST: MedicalOnlies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MedicalOnlyId,Value")] MedicalOnly medicalOnly)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicalOnly).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(medicalOnly);
        }

        // GET: MedicalOnlies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicalOnly medicalOnly = await db.MedicalOnly.FindAsync(id);
            if (medicalOnly == null)
            {
                return HttpNotFound();
            }
            return View(medicalOnly);
        }

        // POST: MedicalOnlies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MedicalOnly medicalOnly = await db.MedicalOnly.FindAsync(id);
            db.MedicalOnly.Remove(medicalOnly);
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
