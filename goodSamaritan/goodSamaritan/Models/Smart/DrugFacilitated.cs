using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class DrugFacilitated
    {
        [Required]
        public int DrugFacilitatedId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Drug Facilidated")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}