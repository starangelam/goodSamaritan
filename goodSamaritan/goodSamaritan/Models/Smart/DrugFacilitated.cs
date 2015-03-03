using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class DrugFacilitated
    {
        public int DrugFacilitatedId { get; set; }
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}