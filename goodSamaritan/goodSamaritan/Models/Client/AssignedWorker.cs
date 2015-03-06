using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class AssignedWorker
    {
        public int AssignedWorkerId { get; set; }

        [Required]
        [Display(Name = "Assigned Worker")]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}