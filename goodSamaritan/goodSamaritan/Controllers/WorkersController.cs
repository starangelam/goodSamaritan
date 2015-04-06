using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using goodSamaritan.Models.Client;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker, Reporter")]
    public class WorkersController : ApiController
    {
        private ClientContext db = new ClientContext();

        // GET: api/Workers
        public IQueryable<AssignedWorker> GetAssignedWorkers()
        {
            return db.AssignedWorkers;
        }

        // GET: api/Workers/5
        [ResponseType(typeof(AssignedWorker))]
        public async Task<IHttpActionResult> GetAssignedWorker(int id)
        {
            AssignedWorker assignedWorker = await db.AssignedWorkers.FindAsync(id);
            if (assignedWorker == null)
            {
                return NotFound();
            }

            return Ok(assignedWorker);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AssignedWorkerExists(int id)
        {
            return db.AssignedWorkers.Count(e => e.AssignedWorkerId == id) > 0;
        }
    }
}