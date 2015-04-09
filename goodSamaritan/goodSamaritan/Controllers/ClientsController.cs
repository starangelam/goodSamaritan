using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using goodSamaritan.Models.Client;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker")]
    public class ClientsController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: Clients
        public async Task<ActionResult> Index()
        {
            Console.WriteLine("ClientsController.Index()");
            var clients = db.Clients
                .Include(c => c.FiscalYear)
                .Include(c => c.AssignedWorkder)
                .Include(c => c.Program)
                .Include(c => c.StatusOfFile);
            return View(await clients.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients
                .Include(c => c.AbuserRelationship)
                .Include(c => c.Age)
                .Include(c => c.AssignedWorkder)
                .Include(c => c.Crisis)
                .Include(c => c.DuplicateFile)
                .Include(c => c.Ethnicity)
                .Include(c => c.FamilyViolenceFile)
                .Include(c => c.FiscalYear)
                .Include(c => c.Incident)
                .Include(c => c.Program)
                .Include(c => c.ReferralContact)
                .Include(c => c.ReferralSource)
                .Include(c => c.RepeatClient)
                .Include(c => c.RiskLevel)
                .Include(c => c.RiskStatus)
                .Include(c => c.Service)
                .Include(c => c.StatusOfFile)
                .Include(c => c.VictimOfIncident)
                .Where(c => c.ClientId == id)
                .SingleOrDefaultAsync();
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationships, "AbuserRelationshipId", "Relationship");
            ViewBag.AgeId = new SelectList(db.Ages, "AgeId", "Range");
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkers, "AssignedWorkerId", "Name");
            ViewBag.CrisisId = new SelectList(db.Crises, "CrisisId", "Type");
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFiles, "DuplicateFileId", "IsDuplicate");
            ViewBag.EthnicityId = new SelectList(db.Ethnicities, "EthnicityId", "Value");
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFiles, "FamilyViolenceFileId", "Exists");
            ViewBag.YearId = new SelectList(db.Years, "YearId", "Range");
            ViewBag.IncidentId = new SelectList(db.Incidents, "IncidentId", "Type");
            ViewBag.ProgramId = new SelectList(db.Programs, "ProgramId", "Type");
            ViewBag.ReferralContactId = new SelectList(db.ReferralContacts, "ReferralContactId", "Contact");
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSources, "ReferralSourceId", "Source");
            ViewBag.RepeatClientId = new SelectList(db.RepeatClients, "RepeatClientId", "IsRepeat");
            ViewBag.RiskLevelId = new SelectList(db.RiskLevels, "RiskLevelId", "Level");
            ViewBag.RiskStatusId = new SelectList(db.RiskStatuses, "RiskStatusId", "Status");
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Type");
            ViewBag.StatusOfFileId = new SelectList(db.StatusesOfFiles, "StatusOfFileId", "Status");
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimsOfIncidents, "VictimOfIncidentId", "Type");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ClientId,YearId,Month,Day,Gender,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SWCFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,AssessmentAssgndTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,ReferralContactId,IncidentId,AbuserSFName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceFileId,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumChildrenZeroToSix,NumChildrenSevenToTwelve,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationships, "AbuserRelationshipId", "Relationship", client.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.Ages, "AgeId", "Range", client.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkers, "AssignedWorkerId", "Name", client.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.Crises, "CrisisId", "Type", client.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFiles, "DuplicateFileId", "IsDuplicate", client.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.Ethnicities, "EthnicityId", "Value", client.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFiles, "FamilyViolenceFileId", "Exists", client.FamilyViolenceFileId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "Range", client.YearId);
            ViewBag.IncidentId = new SelectList(db.Incidents, "IncidentId", "Type", client.IncidentId);
            ViewBag.ProgramId = new SelectList(db.Programs, "ProgramId", "Type", client.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContacts, "ReferralContactId", "Contact", client.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSources, "ReferralSourceId", "Source", client.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClients, "RepeatClientId", "IsRepeat", client.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevels, "RiskLevelId", "Level", client.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatuses, "RiskStatusId", "Status", client.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Type", client.ServiceId);
            ViewBag.StatusOfFileId = new SelectList(db.StatusesOfFiles, "StatusOfFileId", "Status", client.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimsOfIncidents, "VictimOfIncidentId", "Type", client.VictimOfIncidentId);
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationships, "AbuserRelationshipId", "Relationship", client.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.Ages, "AgeId", "Range", client.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkers, "AssignedWorkerId", "Name", client.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.Crises, "CrisisId", "Type", client.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFiles, "DuplicateFileId", "IsDuplicate", client.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.Ethnicities, "EthnicityId", "Value", client.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFiles, "FamilyViolenceFileId", "Exists", client.FamilyViolenceFileId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "Range", client.YearId);
            ViewBag.IncidentId = new SelectList(db.Incidents, "IncidentId", "Type", client.IncidentId);
            ViewBag.ProgramId = new SelectList(db.Programs, "ProgramId", "Type", client.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContacts, "ReferralContactId", "Contact", client.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSources, "ReferralSourceId", "Source", client.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClients, "RepeatClientId", "IsRepeat", client.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevels, "RiskLevelId", "Level", client.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatuses, "RiskStatusId", "Status", client.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Type", client.ServiceId);
            ViewBag.StatusOfFileId = new SelectList(db.StatusesOfFiles, "StatusOfFileId", "Status", client.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimsOfIncidents, "VictimOfIncidentId", "Type", client.VictimOfIncidentId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientId,YearId,Month,Day,Gender,Surname,FirstName,PoliceFileNumber,CourtFileNumber,SWCFileNumber,RiskLevelId,CrisisId,ServiceId,ProgramId,AssessmentAssgndTo,RiskStatusId,AssignedWorkerId,ReferralSourceId,ReferralContactId,IncidentId,AbuserSFName,AbuserRelationshipId,VictimOfIncidentId,FamilyViolenceFileId,EthnicityId,AgeId,RepeatClientId,DuplicateFileId,NumChildrenZeroToSix,NumChildrenSevenToTwelve,StatusOfFileId,DateLastTransferred,DateClosed,DateReOpened")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AbuserRelationshipId = new SelectList(db.AbuserRelationships, "AbuserRelationshipId", "Relationship", client.AbuserRelationshipId);
            ViewBag.AgeId = new SelectList(db.Ages, "AgeId", "Range", client.AgeId);
            ViewBag.AssignedWorkerId = new SelectList(db.AssignedWorkers, "AssignedWorkerId", "Name", client.AssignedWorkerId);
            ViewBag.CrisisId = new SelectList(db.Crises, "CrisisId", "Type", client.CrisisId);
            ViewBag.DuplicateFileId = new SelectList(db.DuplicateFiles, "DuplicateFileId", "IsDuplicate", client.DuplicateFileId);
            ViewBag.EthnicityId = new SelectList(db.Ethnicities, "EthnicityId", "Value", client.EthnicityId);
            ViewBag.FamilyViolenceFileId = new SelectList(db.FamilyViolenceFiles, "FamilyViolenceFileId", "Exists", client.FamilyViolenceFileId);
            ViewBag.YearId = new SelectList(db.Years, "YearId", "Range", client.YearId);
            ViewBag.IncidentId = new SelectList(db.Incidents, "IncidentId", "Type", client.IncidentId);
            ViewBag.ProgramId = new SelectList(db.Programs, "ProgramId", "Type", client.ProgramId);
            ViewBag.ReferralContactId = new SelectList(db.ReferralContacts, "ReferralContactId", "Contact", client.ReferralContactId);
            ViewBag.ReferralSourceId = new SelectList(db.ReferralSources, "ReferralSourceId", "Source", client.ReferralSourceId);
            ViewBag.RepeatClientId = new SelectList(db.RepeatClients, "RepeatClientId", "IsRepeat", client.RepeatClientId);
            ViewBag.RiskLevelId = new SelectList(db.RiskLevels, "RiskLevelId", "Level", client.RiskLevelId);
            ViewBag.RiskStatusId = new SelectList(db.RiskStatuses, "RiskStatusId", "Status", client.RiskStatusId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Type", client.ServiceId);
            ViewBag.StatusOfFileId = new SelectList(db.StatusesOfFiles, "StatusOfFileId", "Status", client.StatusOfFileId);
            ViewBag.VictimOfIncidentId = new SelectList(db.VictimsOfIncidents, "VictimOfIncidentId", "Type", client.VictimOfIncidentId);
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients
                .Include(c => c.AbuserRelationship)
                .Include(c => c.Age)
                .Include(c => c.AssignedWorkder)
                .Include(c => c.Crisis)
                .Include(c => c.DuplicateFile)
                .Include(c => c.Ethnicity)
                .Include(c => c.FamilyViolenceFile)
                .Include(c => c.FiscalYear)
                .Include(c => c.Incident)
                .Include(c => c.Program)
                .Include(c => c.ReferralContact)
                .Include(c => c.ReferralSource)
                .Include(c => c.RepeatClient)
                .Include(c => c.RiskLevel)
                .Include(c => c.RiskStatus)
                .Include(c => c.Service)
                .Include(c => c.StatusOfFile)
                .Include(c => c.VictimOfIncident)
                .Where(c => c.ClientId == id)
                .SingleOrDefaultAsync();

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Client client = await db.Clients.FindAsync(id);
            db.Clients.Remove(client);
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

        public PartialViewResult RenderSmartPartial()
        {
            Console.WriteLine("RenderSmartPartial()");
            return PartialView("_EditSmartPartial");
        }
    }
}
