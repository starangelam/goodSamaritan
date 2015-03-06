using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class AbuserRelationship
    {
        public int AbuserRelationshipId { get; set; }

        [Required]
        [Display(Name = "Abuser Relationship")]
        [StringLength(30)]
        public string Relationship { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}