using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RepeatClient
    {
        public int RepeatClientId { get; set; }
        public string IsRepeat { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}