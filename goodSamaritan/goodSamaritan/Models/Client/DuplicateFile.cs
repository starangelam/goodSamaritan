using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class DuplicateFile
    {
        public int DuplicateFileId { get; set; }
        public string IsDuplicate { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}