﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using goodSamaritan.Models.Client;

namespace GoodSamaritan.Controllers
{
    public class ReportsController : ApiController
    {
        private ClientContext db = new ClientContext();

        // GET: api/Reports
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reports/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reports
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reports/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reports/5
        public void Delete(int id)
        {
        }
    }
}