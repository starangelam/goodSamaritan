using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class AbuserRelationship
    {
        public int AbuserRelationshipId { get; set; }
        public string Relationship { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}