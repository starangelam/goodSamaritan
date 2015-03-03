namespace GoodSamaritan.Migrations.SmartMigration
{
    using GoodSamaritan.Models.Smart;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.Smart.SmartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SmartMigration";
        }

        protected override void Seed(GoodSamaritan.Models.Smart.SmartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.SexExploitations.AddOrUpdate(
                s => s.Value,
                new SexExploitation { Value = "Yes" },
                new SexExploitation { Value = "No" },
                new SexExploitation { Value = "N/A" }
                );

            context.MultiplePerps.AddOrUpdate(
                m => m.Value,
                new MultiplePerps { Value = "Yes" },
                new MultiplePerps { Value = "No" },
                new MultiplePerps { Value = "N/A" }
                );

            context.DrugsFacilitated.AddOrUpdate(
                m => m.Value,
                new DrugFacilitated { Value = "Yes" },
                new DrugFacilitated { Value = "No" },
                new DrugFacilitated { Value = "N/A" }
                );

            context.CitiesOfAssault.AddOrUpdate(
                c => c.Value,
                new CityOfAssault { Value = "Surrey" },
                new CityOfAssault { Value = "Abbotsford" },
                new CityOfAssault { Value = "Agassiz" },
                new CityOfAssault { Value = "Boston Bar" },
                new CityOfAssault { Value = "Burnaby" },
                new CityOfAssault { Value = "Chilliwack" },
                new CityOfAssault { Value = "Coquitlam" },
                new CityOfAssault { Value = "Delta" },
                new CityOfAssault { Value = "Harrison Hot Springs" },
                new CityOfAssault { Value = "Hope" },
                new CityOfAssault { Value = "Langley" },
                new CityOfAssault { Value = "Maple Ridge" },
                new CityOfAssault { Value = "Mission" },
                new CityOfAssault { Value = "New Westminster" },
                new CityOfAssault { Value = "Pitt Meadows" },
                new CityOfAssault { Value = "Port Coquitlam" },
                new CityOfAssault { Value = "Port Moody" },
                new CityOfAssault { Value = "Vancouver" },
                new CityOfAssault { Value = "White Rock" },
                new CityOfAssault { Value = "Yale" },
                new CityOfAssault { Value = "Other – BC" },
                new CityOfAssault { Value = "Out-of-Province" },
                new CityOfAssault { Value = "International" }
                );

            context.CitiesOfResidence.AddOrUpdate(
                c => c.Value,
                new CityOfResidence { Value = "Surrey" },
                new CityOfResidence { Value = "Abbotsford" },
                new CityOfResidence { Value = "Agassiz" },
                new CityOfResidence { Value = "Boston Bar" },
                new CityOfResidence { Value = "Burnaby" },
                new CityOfResidence { Value = "Chilliwack" },
                new CityOfResidence { Value = "Coquitlam" },
                new CityOfResidence { Value = "Delta" },
                new CityOfResidence { Value = "Harrison Hot Springs" },
                new CityOfResidence { Value = "Hope" },
                new CityOfResidence { Value = "Langley" },
                new CityOfResidence { Value = "Maple Ridge" },
                new CityOfResidence { Value = "Mission" },
                new CityOfResidence { Value = "New Westminster" },
                new CityOfResidence { Value = "Pitt Meadows" },
                new CityOfResidence { Value = "Port Coquitlam" },
                new CityOfResidence { Value = "Port Moody" },
                new CityOfResidence { Value = "Vancouver" },
                new CityOfResidence { Value = "White Rock" },
                new CityOfResidence { Value = "Yale" },
                new CityOfResidence { Value = "Other – BC" },
                new CityOfResidence { Value = "Out-of-Province" },
                new CityOfResidence { Value = "International" }
                );

            context.ReferringHospitals.AddOrUpdate(
                r => r.Value,
                new ReferringHospital { Value = "Abbotsford Regional Hospital" },
                new ReferringHospital { Value = "Surrey Memorial Hospital" },
                new ReferringHospital { Value = "Burnaby Hospital" },
                new ReferringHospital { Value = "Chilliwack General Hospital" },
                new ReferringHospital { Value = "Delta Hospital" },
                new ReferringHospital { Value = "Eagle Ridge Hospital" },
                new ReferringHospital { Value = "Fraser Canyon Hospital" },
                new ReferringHospital { Value = "Langley Hospital" },
                new ReferringHospital { Value = "Mission Hospital" },
                new ReferringHospital { Value = "Peace Arch Hospita" },
                new ReferringHospital { Value = "Ridge Meadows Hospital" },
                new ReferringHospital { Value = "Royal Columbia Hospital" }
                );

            context.HospitalsAttended.AddOrUpdate(
                h => h.Value,
                new HospitalAttended { Value = "Abbotsford Regional Hospital" },
                new HospitalAttended { Value = "Surrey Memorial Hospital" },
                new HospitalAttended { Value = "Burnaby Hospital" },
                new HospitalAttended { Value = "Chilliwack General Hospital" },
                new HospitalAttended { Value = "Delta Hospital" },
                new HospitalAttended { Value = "Eagle Ridge Hospital" },
                new HospitalAttended { Value = "Fraser Canyon Hospital" },
                new HospitalAttended { Value = "Langley Hospital" },
                new HospitalAttended { Value = "Mission Hospital" },
                new HospitalAttended { Value = "Peace Arch Hospita" },
                new HospitalAttended { Value = "Ridge Meadows Hospital" },
                new HospitalAttended { Value = "Royal Columbia Hospital" }
                );

            context.SocialWorkAttendances.AddOrUpdate(
                a => a.Value,
                new SocialWorkAttendance { Value = "Yes" },
                new SocialWorkAttendance { Value = "No" },
                new SocialWorkAttendance { Value = "N/A" }
                );

            context.PoliceAttendances.AddOrUpdate(
                a => a.Value,
                new PoliceAttendance { Value = "Yes" },
                new PoliceAttendance { Value = "No" },
                new PoliceAttendance { Value = "N/A" }
                );

            context.VictimServicesAttendances.AddOrUpdate(
                a => a.Value,
                new VictimServicesAttendance { Value = "Yes" },
                new VictimServicesAttendance { Value = "No" },
                new VictimServicesAttendance { Value = "N/A" }
                );

            context.MedicalOnly.AddOrUpdate(
                m => m.Value,
                new MedicalOnly { Value = "Yes" },
                new MedicalOnly { Value = "No" },
                new MedicalOnly { Value = "N/A" }
                );

            context.EvidenceStored.AddOrUpdate(
                new EvidenceStored { Value = "Yes" },
                new EvidenceStored { Value = "No" },
                new EvidenceStored { Value = "N/A" }
                );

            context.HivMeds.AddOrUpdate(
                new HivMeds { Value = "Yes" },
                new HivMeds { Value = "No" },
                new HivMeds { Value = "N/A" }
                );

            context.ReferredToCbvs.AddOrUpdate(
                new ReferredToCbvs { Value = "Yes" },
                new ReferredToCbvs { Value = "No" },
                new ReferredToCbvs { Value = "N/A" }
                );

            context.PoliceReported.AddOrUpdate(
                new PoliceReported { Value = "Yes" },
                new PoliceReported { Value = "No" },
                new PoliceReported { Value = "N/A" }
                );

            context.ThirdPartyReports.AddOrUpdate(
                new ThirdPartyReport { Value = "Yes" },
                new ThirdPartyReport { Value = "No" },
                new ThirdPartyReport { Value = "N/A" }
                );

            context.BadDateReports.AddOrUpdate(
                new BadDateReport { Value = "Yes" },
                new BadDateReport { Value = "No" },
                new BadDateReport { Value = "N/A" }
                );
        }
    }
}
