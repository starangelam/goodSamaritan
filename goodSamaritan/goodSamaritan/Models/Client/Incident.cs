using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Incident
    {
        public int IncidentId { get; set; }
        public string Type { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}