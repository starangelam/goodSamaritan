using GoodSamaritan.Models.Smart;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace goodSamaritan.Models.Client
{
    public class ClientContext : DbContext
    {
        public ClientContext() : base("DefaultConnection") { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<AbuserRelationship> AbuserRelationships { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<AssignedWorker> AssignedWorkers { get; set; }

        public DbSet<Crisis> Crises { get; set; }
        public DbSet<DuplicateFile> DuplicateFiles { get; set; }
        public DbSet<Ethnicity> Ethnicities { get; set; }
        public DbSet<FamilyViolenceFile> FamilyViolenceFiles { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ReferralContact> ReferralContacts { get; set; }
        public DbSet<ReferralSource> ReferralSources { get; set; }
        public DbSet<RepeatClient> RepeatClients { get; set; }
        public DbSet<RiskLevel> RiskLevels { get; set; }
        public DbSet<RiskStatus> RiskStatuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<VictimOfIncident> VictimsOfIncidents { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<StatusOfFile> StatusesOfFiles { get; set; }

        // SMART entities
        public DbSet<Smart> Smarts { get; set; }

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
        public DbSet<EvidenceStored> EvidenceStored { get; set; }
        public DbSet<HivMeds> HivMeds { get; set; }
        public DbSet<ReferredToCbvs> ReferredToCbvs { get; set; }
        public DbSet<PoliceReported> PoliceReported { get; set; }
        public DbSet<ThirdPartyReport> ThirdPartyReports { get; set; }
        public DbSet<BadDateReport> BadDateReports { get; set; }
    }
}