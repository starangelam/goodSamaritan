using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Year
    {
        public int YearId { get; set; }

        [Required]
        [Display(Name = "Fiscal Year")]
        [StringLength(30)]
        public string Range { get; set; }
    }
}