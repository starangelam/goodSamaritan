using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Ethnicity
    {
        public int EthnicityId { get; set; }
        [Required]
        [Display(Name = "Ethnicity")]
        [StringLength(30)]
        public string Value { get; set; }
    }
}