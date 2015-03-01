using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Ethnicity
    {
        public int EthnicityId { get; set; }
        public string Value { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}