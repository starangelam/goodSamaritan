using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class PoliceAttendance
    {
        public int PoliceAttendanceId { get; set; }
        public string Value { get; set; }
        public ICollection<Smart> Smarts { get; set; }
    }
}