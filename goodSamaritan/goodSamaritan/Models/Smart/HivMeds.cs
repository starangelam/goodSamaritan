using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class HivMeds
    {
        public int HivMedsId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "HIV Meds")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}