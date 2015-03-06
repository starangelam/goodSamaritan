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
    [Authorize(Roles = "Administrator, Worker")]
    public class SmartsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Smarts
        public async Task<ActionResult> Index()
        {
            var smarts = db.Smarts
                .Include(s => s.BadDateReport)
                .Include(s => s.CityOfAssault)
                .Include(s => s.CityOfResidence)
                .Include(s => s.Client)
                .Include(s => s.DrugFacilitated)
                .Include(s => s.EvidenceStored)
                .Include(s => s.HivMeds)
                .Include(s => s.HospitalAttended)
                .Include(s => s.MedicalOnly)
                .Include(s => s.MultiplePerps)
                .Include(s => s.PoliceAttendance)
                .Include(s => s.PoliceReported)
                .Include(s => s.ReferredToCbvs)
                .Include(s => s.ReferringHospital)
                .Include(s => s.SexExploitation)
                .Include(s => s.SocialWorkAttendance)
                .Include(s => s.ThirdPartyReport);
            return View(await smarts.ToListAsync());
        }

        // GET: Smarts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // GET: Smarts/Create
        public ActionResult Create()
        {
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "IsBadDateReported");
            ViewBag.CityOfAssaultId = new SelectList(db.CitiesOfAssault, "CityOfAssaultId", "Value");
            ViewBag.CityOfResidenceId = new SelectList(db.CitiesOfResidence, "CityOfResidenceId", "Value");
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "Surname");
            ViewBag.DrugFacilitatedId = new SelectList(db.DrugsFacilitated, "DrugFacilitatedId", "Value");
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStored, "EvidenceStoredId", "Value");
            ViewBag.HivMedsId = new SelectList(db.HivMeds, "HivMedsId", "Value");
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalsAttended, "HospitalAttendedId", "Value");
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnly, "MedicalOnlyId", "Value");
            ViewBag.MultiplePerpsId = new SelectList(db.MultiplePerps, "MultiplePerpsId", "Value");
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "Value");
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReported, "PoliceReportedId", "Value");
            ViewBag.ReferredToCbvsId = new SelectList(db.ReferredToCbvs, "ReferredToCbvsId", "Value");
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "Value");
            ViewBag.SexExploitationId = new SelectList(db.SexExploitations, "SexExploitationId", "Value");
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "Value");
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "Value");
            return View();
        }

        // POST: Smarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SmartId,ClientId,SexExploitationId,MultiplePerpsId,DrugFacilitatedId,CityOfAssaultId,CityOfResidenceId,AccompanimentMinutes,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServiceAttendanceId,MedicalOnlyId,EvidenceStoredId,HivMedsId,ReferredToCbvsId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePracticioner")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Smarts.Add(smart);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "IsBadDateReported", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CitiesOfAssault, "CityOfAssaultId", "Value", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CitiesOfResidence, "CityOfResidenceId", "Value", smart.CityOfResidenceId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "Surname", smart.ClientId);
            ViewBag.DrugFacilitatedId = new SelectList(db.DrugsFacilitated, "DrugFacilitatedId", "Value", smart.DrugFacilitatedId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStored, "EvidenceStoredId", "Value", smart.EvidenceStoredId);
            ViewBag.HivMedsId = new SelectList(db.HivMeds, "HivMedsId", "Value", smart.HivMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalsAttended, "HospitalAttendedId", "Value", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnly, "MedicalOnlyId", "Value", smart.MedicalOnlyId);
            ViewBag.MultiplePerpsId = new SelectList(db.MultiplePerps, "MultiplePerpsId", "Value", smart.MultiplePerpsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "Value", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReported, "PoliceReportedId", "Value", smart.PoliceReportedId);
            ViewBag.ReferredToCbvsId = new SelectList(db.ReferredToCbvs, "ReferredToCbvsId", "Value", smart.ReferredToCbvsId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "Value", smart.ReferringHospitalId);
            ViewBag.SexExploitationId = new SelectList(db.SexExploitations, "SexExploitationId", "Value", smart.SexExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "Value", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "Value", smart.ThirdPartyReportId);
            return View(smart);
        }

        // GET: Smarts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "IsBadDateReported", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CitiesOfAssault, "CityOfAssaultId", "Value", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CitiesOfResidence, "CityOfResidenceId", "Value", smart.CityOfResidenceId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "Surname", smart.ClientId);
            ViewBag.DrugFacilitatedId = new SelectList(db.DrugsFacilitated, "DrugFacilitatedId", "Value", smart.DrugFacilitatedId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStored, "EvidenceStoredId", "Value", smart.EvidenceStoredId);
            ViewBag.HivMedsId = new SelectList(db.HivMeds, "HivMedsId", "Value", smart.HivMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalsAttended, "HospitalAttendedId", "Value", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnly, "MedicalOnlyId", "Value", smart.MedicalOnlyId);
            ViewBag.MultiplePerpsId = new SelectList(db.MultiplePerps, "MultiplePerpsId", "Value", smart.MultiplePerpsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "Value", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReported, "PoliceReportedId", "Value", smart.PoliceReportedId);
            ViewBag.ReferredToCbvsId = new SelectList(db.ReferredToCbvs, "ReferredToCbvsId", "Value", smart.ReferredToCbvsId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "Value", smart.ReferringHospitalId);
            ViewBag.SexExploitationId = new SelectList(db.SexExploitations, "SexExploitationId", "Value", smart.SexExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "Value", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "Value", smart.ThirdPartyReportId);
            return View(smart);
        }

        // POST: Smarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SmartId,ClientId,SexExploitationId,MultiplePerpsId,DrugFacilitatedId,CityOfAssaultId,CityOfResidenceId,AccompanimentMinutes,ReferringHospitalId,HospitalAttendedId,SocialWorkAttendanceId,PoliceAttendanceId,VictimServiceAttendanceId,MedicalOnlyId,EvidenceStoredId,HivMedsId,ReferredToCbvsId,PoliceReportedId,ThirdPartyReportId,BadDateReportId,NumberTransportsProvided,ReferredToNursePracticioner")] Smart smart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smart).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BadDateReportId = new SelectList(db.BadDateReports, "BadDateReportId", "IsBadDateReported", smart.BadDateReportId);
            ViewBag.CityOfAssaultId = new SelectList(db.CitiesOfAssault, "CityOfAssaultId", "Value", smart.CityOfAssaultId);
            ViewBag.CityOfResidenceId = new SelectList(db.CitiesOfResidence, "CityOfResidenceId", "Value", smart.CityOfResidenceId);
            ViewBag.ClientId = new SelectList(db.Clients, "ClientId", "Surname", smart.ClientId);
            ViewBag.DrugFacilitatedId = new SelectList(db.DrugsFacilitated, "DrugFacilitatedId", "Value", smart.DrugFacilitatedId);
            ViewBag.EvidenceStoredId = new SelectList(db.EvidenceStored, "EvidenceStoredId", "Value", smart.EvidenceStoredId);
            ViewBag.HivMedsId = new SelectList(db.HivMeds, "HivMedsId", "Value", smart.HivMedsId);
            ViewBag.HospitalAttendedId = new SelectList(db.HospitalsAttended, "HospitalAttendedId", "Value", smart.HospitalAttendedId);
            ViewBag.MedicalOnlyId = new SelectList(db.MedicalOnly, "MedicalOnlyId", "Value", smart.MedicalOnlyId);
            ViewBag.MultiplePerpsId = new SelectList(db.MultiplePerps, "MultiplePerpsId", "Value", smart.MultiplePerpsId);
            ViewBag.PoliceAttendanceId = new SelectList(db.PoliceAttendances, "PoliceAttendanceId", "Value", smart.PoliceAttendanceId);
            ViewBag.PoliceReportedId = new SelectList(db.PoliceReported, "PoliceReportedId", "Value", smart.PoliceReportedId);
            ViewBag.ReferredToCbvsId = new SelectList(db.ReferredToCbvs, "ReferredToCbvsId", "Value", smart.ReferredToCbvsId);
            ViewBag.ReferringHospitalId = new SelectList(db.ReferringHospitals, "ReferringHospitalId", "Value", smart.ReferringHospitalId);
            ViewBag.SexExploitationId = new SelectList(db.SexExploitations, "SexExploitationId", "Value", smart.SexExploitationId);
            ViewBag.SocialWorkAttendanceId = new SelectList(db.SocialWorkAttendances, "SocialWorkAttendanceId", "Value", smart.SocialWorkAttendanceId);
            ViewBag.ThirdPartyReportId = new SelectList(db.ThirdPartyReports, "ThirdPartyReportId", "Value", smart.ThirdPartyReportId);
            return View(smart);
        }

        // GET: Smarts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Smart smart = await db.Smarts.FindAsync(id);
            if (smart == null)
            {
                return HttpNotFound();
            }
            return View(smart);
        }

        // POST: Smarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Smart smart = await db.Smarts.FindAsync(id);
            db.Smarts.Remove(smart);
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
