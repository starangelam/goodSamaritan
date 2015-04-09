using goodSamaritan.Models.Client;
using GoodSamaritan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker, Reporter")]
    public class ReportController : Controller
    {
        ClientContext db = new ClientContext();
        // GET: Report
        public ActionResult Index()
        {
            // TODO if check on selected null, redirect
            //int selectedWorker = db.AssignedWorkers.FirstOrDefault().AssignedWorkerId;
            //int selectedStatus = db.StatusesOfFiles.Where( s => s.Status == "Open").FirstOrDefault().StatusOfFileId;
            
            ViewBag.Workers = new SelectList(db.AssignedWorkers, "AssignedWorkerId", "Name");
            ViewBag.Status = new SelectList(db.StatusesOfFiles, "StatusOfFileId", "Status");

            //Report report = new Report(selectedWorker, selectedStatus);

            return View();
        }

        [HttpPost]
        [ActionName("Report")]
        public ActionResult GenerateReport(FormCollection reportFilters)
        {
            ViewBag.ReportDate = DateTime.Now.ToString("yyyy-MM-dd");
            // TODO check for null?
            int selectedWorker = Convert.ToInt32(reportFilters[0]);
            int selectedStatus = Convert.ToInt32(reportFilters[1]);

            Report report = new Report(selectedWorker, selectedStatus);

            return View(report);
        }
    }
}