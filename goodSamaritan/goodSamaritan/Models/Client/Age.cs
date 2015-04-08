using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Age
    {
        public int AgeId { get; set; }

        [Required]
        [Display(Name = "Age Range")]
        [StringLength(30)]
        public string Range { get; set; }
    }
}