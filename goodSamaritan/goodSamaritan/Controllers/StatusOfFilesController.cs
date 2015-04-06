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
    public class StatusOfFilesController : ApiController
    {
        private ClientContext db = new ClientContext();

        // GET: api/StatusOfFiles
        public IQueryable<StatusOfFile> GetStatusesOfFiles()
        {
            return db.StatusesOfFiles;
        }

        // GET: api/StatusOfFiles/5
        [ResponseType(typeof(StatusOfFile))]
        public async Task<IHttpActionResult> GetStatusOfFile(int id)
        {
            StatusOfFile statusOfFile = await db.StatusesOfFiles.FindAsync(id);
            if (statusOfFile == null)
            {
                return NotFound();
            }

            return Ok(statusOfFile);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StatusOfFileExists(int id)
        {
            return db.StatusesOfFiles.Count(e => e.StatusOfFileId == id) > 0;
        }
    }
}