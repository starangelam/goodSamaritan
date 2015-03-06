using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class StatusOfFile
    {
        public int StatusOfFileId { get; set; }
        [Required]
        [Display(Name = "Status Of File")]
        [StringLength(30)]
        public string Status { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}