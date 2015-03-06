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
    public class CityOfResidencesController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: CityOfResidences
        public async Task<ActionResult> Index()
        {
            return View(await db.CitiesOfResidence.ToListAsync());
        }

        // GET: CityOfResidences/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = await db.CitiesOfResidence.FindAsync(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CityOfResidences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CityOfResidenceId,Value")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.CitiesOfResidence.Add(cityOfResidence);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = await db.CitiesOfResidence.FindAsync(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CityOfResidenceId,Value")] CityOfResidence cityOfResidence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cityOfResidence).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cityOfResidence);
        }

        // GET: CityOfResidences/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityOfResidence cityOfResidence = await db.CitiesOfResidence.FindAsync(id);
            if (cityOfResidence == null)
            {
                return HttpNotFound();
            }
            return View(cityOfResidence);
        }

        // POST: CityOfResidences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CityOfResidence cityOfResidence = await db.CitiesOfResidence.FindAsync(id);
            db.CitiesOfResidence.Remove(cityOfResidence);
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
