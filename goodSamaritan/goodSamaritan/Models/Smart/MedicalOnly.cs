using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class MedicalOnly
    {
        [Required]
        public int MedicalOnlyId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Medical Only")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}