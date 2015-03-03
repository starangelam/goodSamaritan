using goodSamaritan.Models.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class SmartContext : DbContext
    {
        public SmartContext() : base("DefaultConnection") { }

        public DbSet<Smart> Smarts{ get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<SexExploitation> SexExploitations { get; set; }
        public DbSet<MultiplePerps> MultiplePerps { get; set; }
        public DbSet<DrugFacilitated> DrugsFacilitated { get; set; }
        public DbSet<CityOfAssault> CitiesOfAssault { get; set; }
        public DbSet<CityOfResidence> CitiesOfResidence { get; set; }
        public DbSet<ReferringHospital> ReferringHospitals { get; set; }
        public DbSet<HospitalAttended> HospitalsAttended { get; set; }
        public DbSet<SocialWorkAttendance> SocialWorkAttendances { get; set; }
        public DbSet<PoliceAttendance> PoliceAttendances { get; set; }
        public DbSet<VictimServicesAttendance> VictimServicesAttendances { get; set; }
        public DbSet<MedicalOnly> MedicalOnly { get; set; }
        public DbSet<HivMeds> HivMeds { get; set; }
        public DbSet<ReferredToCbvs> ReferredToCbvs { get; set; }
        public DbSet<PoliceReported> PoliceReported { get; set; }
        public DbSet<ThirdPartyReport> ThirdPartyReports { get; set; }
        public DbSet<BadDateReport> BadDateReports { get; set; }
    }
}