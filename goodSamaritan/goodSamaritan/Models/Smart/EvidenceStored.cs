using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class EvidenceStored
    {
        [Required]
        public int EvidenceStoredId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Evidence Stored")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}