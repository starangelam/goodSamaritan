using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class DuplicateFile
    {
        public int DuplicateFileId { get; set; }
        [Required]
        [Display(Name = "Duplicate File")]
        [StringLength(30)]
        public string IsDuplicate { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}