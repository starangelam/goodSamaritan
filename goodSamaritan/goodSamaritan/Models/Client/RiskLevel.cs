using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class RiskLevel
    {
        public int RiskLevelId { get; set; }
        [Required]
        [Display(Name = "Risk Level")]
        [StringLength(30)]
        public string Level { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}