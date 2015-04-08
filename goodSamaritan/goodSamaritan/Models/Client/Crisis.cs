using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Crisis
    {
        public int CrisisId { get; set; }

        [Required]
        [Display(Name = "Crisis")]
        [StringLength(30)]
        public string Type { get; set; }
    }
}