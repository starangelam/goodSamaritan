using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RiskLevel
    {
        public int RiskLevelId { get; set; }
        public string Level { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}