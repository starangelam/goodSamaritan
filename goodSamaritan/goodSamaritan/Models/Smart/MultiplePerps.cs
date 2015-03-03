using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class MultiplePerps
    {
        public int MultiplePerpsId { get; set; }
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}