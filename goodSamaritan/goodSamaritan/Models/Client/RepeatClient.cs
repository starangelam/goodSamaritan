using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RepeatClient
    {
        public int RepeatClientId { get; set; }
        [Required]
        [Display(Name = "Repeat Client")]
        [StringLength(30)]
        public string IsRepeat { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}