using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class CityOfResidence
    {
        [Required]
        public int CityOfResidenceId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "City of Residence")]
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}