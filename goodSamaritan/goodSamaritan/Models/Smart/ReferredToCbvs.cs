using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GoodSamaritan.Models.Smart
{
    public class ReferredToCbvs
    {
        public int ReferredToCbvsId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Referred To CBVS")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}