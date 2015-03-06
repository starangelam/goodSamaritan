using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GoodSamaritan.Models.Smart
{
    public class ReferringHospital
    {
        public int ReferringHospitalId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Referring Hospital")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}