using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class FamilyViolenceFile
    {
        public int FamilyViolenceFileId { get; set; }
        [Required]
        [Display(Name = "Family Violence File Exists")]
        [StringLength(30)]
        public string Exists { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}