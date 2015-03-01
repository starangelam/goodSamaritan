using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class ReferralSource
    {
        public int ReferralSourceId { get; set; }
        public string Source { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}