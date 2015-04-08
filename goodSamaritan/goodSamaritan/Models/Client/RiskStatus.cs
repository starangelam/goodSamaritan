using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RiskStatus
    {
        public int RiskStatusId { get; set; }
        [Required]
        [Display(Name = "Risk Status")]
        [StringLength(30)]
        public string Status { get; set; }
    }
}