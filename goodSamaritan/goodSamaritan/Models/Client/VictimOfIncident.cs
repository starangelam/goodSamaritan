using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class VictimOfIncident
    {
        public int VictimOfIncidentId { get; set; }
        [Required]
        [Display(Name = "Victim Of Incident")]
        [StringLength(30)]
        public string Type { get; set; }
    }
}