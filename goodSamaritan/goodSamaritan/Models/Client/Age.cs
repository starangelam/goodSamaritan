using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Age
    {
        public int AgeId { get; set; }
        public string Range { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}