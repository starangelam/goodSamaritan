using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GoodSamaritan.Models.Smart
{
    public class ThirdPartyReport
    {
        public int ThirdPartyReportId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Third Party Report")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}