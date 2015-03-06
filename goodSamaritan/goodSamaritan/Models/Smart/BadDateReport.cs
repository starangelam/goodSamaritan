using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class BadDateReport
    {
        public int BadDateReportId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Is Bad Date Reported")]
        public string IsBadDateReported { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}