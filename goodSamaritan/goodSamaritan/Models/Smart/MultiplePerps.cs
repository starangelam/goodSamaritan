using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class MultiplePerps
    {
        [Required]
        public int MultiplePerpsId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Multiple Perps")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}