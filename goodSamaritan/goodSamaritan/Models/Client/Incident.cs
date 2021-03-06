﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class Incident
    {
        public int IncidentId { get; set; }
        [Required]
        [Display(Name = "Incident Type")]
        [StringLength(64)]
        public string Type { get; set; }
    }
}