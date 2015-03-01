using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class StatusOfFile
    {
        public int StatusOfFileId { get; set; }
        public string Status { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}