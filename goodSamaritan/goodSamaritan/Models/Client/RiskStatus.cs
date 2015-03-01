using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RiskStatus
    {
        public int RiskStatusId { get; set; }
        public string Status { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}