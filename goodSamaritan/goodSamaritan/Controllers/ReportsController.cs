using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using goodSamaritan.Models.Client;
using System.Web.Http.Cors;
using GoodSamaritan.Models;

namespace GoodSamaritan.Controllers
{
    [Authorize(Roles = "Administrator, Worker, Reporter")]
    public class ReportsController : ApiController
    {
        private ClientContext db = new ClientContext();

        // GET: api/Reports/5
        [Route("api/reports/{workerId}/status/{statusId}")]
        public Report Get(int workerId, int statusId)
        {

            return new Report(workerId, statusId);
        }
    }
}
