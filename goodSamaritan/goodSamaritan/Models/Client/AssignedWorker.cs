using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class AssignedWorker
    {
        public int AssignedWorkerId { get; set; }
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}