using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
	public class Service
	{
        public int ServiceId { get; set; }
        [Required]
        [Display(Name = "Service")]
        [StringLength(30)]
        public string Type { get; set; }
        public ICollection<Client> Clients { get; set; }
	}
}