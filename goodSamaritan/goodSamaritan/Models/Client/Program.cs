using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Program
    {
        public int ProgramId { get; set; }
        [Required]
        [Display(Name = "Program Type")]
        [StringLength(30)]
        public string Type { get; set; }
    }
}