using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Year
    {
        public int YearId { get; set; }
        public string Range { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}