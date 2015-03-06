using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class ReferralSource
    {
        public int ReferralSourceId { get; set; }
        [Required]
        [Display(Name = "Referral Source")]
        [StringLength(30)]
        public string Source { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}