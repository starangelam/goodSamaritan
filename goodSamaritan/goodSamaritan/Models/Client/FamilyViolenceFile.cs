using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class FamilyViolenceFile
    {
        public int FamilyViolenceFileId { get; set; }
        public string Exists { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}