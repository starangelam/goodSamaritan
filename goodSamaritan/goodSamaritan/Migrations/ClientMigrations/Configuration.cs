namespace GoodSamaritan.Migrations.ClientMigrations
{
    using goodSamaritan.Models.Client;
    using GoodSamaritan.Models.Smart;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<goodSamaritan.Models.Client.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClientMigrations";
        }

        //private void seedFamilyViolenceFiles(ClientContext context)
        protected override void Seed(goodSamaritan.Models.Client.ClientContext ctx)
        {
            //  Client information seed
            seedAbuserRelationships(ctx);
            seedAges(ctx);
            seedAssignedWorkers(ctx);
            seedCrisis(ctx);
            seedDuplicateFiles(ctx);
            seedEthnicities(ctx);
            seedFamilyViolenceFiles(ctx);
            seedIncidents(ctx);
            seedPrograms(ctx);
            seedReferralContacts(ctx);
            seedReferralSources(ctx);
            seedRepeatClients(ctx);
            seedRiskLevels(ctx);
            seedRiskStatuses(ctx);
            seedServices(ctx);
            seedStatusesOfFiles(ctx);
            seedVictimsOfIncidents(ctx);
            seedYears(ctx);

            // Add sample Clients
            seedClients(ctx);

            // SMART infromation seed
            seedSmartLookups(ctx);
            seedSmartEntity(ctx);
        }


        private void seedAbuserRelationships(ClientContext context)
        {
            // Populate Abuser Relationships values
            context.AbuserRelationships.AddOrUpdate(
                a => a.Relationship,
                new AbuserRelationship
                {
                    Relationship = "Acquaintance"
                }, new AbuserRelationship
                {
                    Relationship = "Bad Date"
                }, new AbuserRelationship
                {
                    Relationship = "DNA"
                }, new AbuserRelationship
                {
                    Relationship = "Ex-Partner"
                }, new AbuserRelationship
                {
                    Relationship = "Friend"
                }, new AbuserRelationship
                {
                    Relationship = "Multiple Perps"
                }, new AbuserRelationship
                {
                    Relationship = "N/A"
                }, new AbuserRelationship
                {
                    Relationship = "Other"
                }, new AbuserRelationship
                {
                    Relationship = "Other Familial"
                }, new AbuserRelationship
                {
                    Relationship = "Parent"
                }, new AbuserRelationship
                {
                    Relationship = "Partner"
                }, new AbuserRelationship
                {
                    Relationship = "Sibling"
                }, new AbuserRelationship
                {
                    Relationship = "Stranger"
                }
            );
            context.SaveChanges();
        }
        private void seedAges(ClientContext context)
        {
            // Populate Age data
            context.Ages.AddOrUpdate(
                a => a.Range,
                new Age
                {
                    Range = "Adult >24 <65"
                }, new Age
                {
                    Range = "Youth >12 <19"
                }, new Age
                {
                    Range = "Youth >18 <25"
                }, new Age
                {
                    Range = "Child <13"
                }, new Age
                {
                    Range = "Senior >64"
                }
                );
            context.SaveChanges();
        }
        private void seedAssignedWorkers(ClientContext context)
        {
            // Populate Assigned Workers data
            context.AssignedWorkers.AddOrUpdate(
                a => a.Name,
                new AssignedWorker
                {
                    Name = "Michelle"
                }, new AssignedWorker
                {
                    Name = "Tyra"
                }, new AssignedWorker
                {
                    Name = "Louise"
                }, new AssignedWorker
                {
                    Name = "Angela"
                }, new AssignedWorker
                {
                    Name = "Dave"
                }, new AssignedWorker
                {
                    Name = "Troy"
                }, new AssignedWorker
                {
                    Name = "Michael"
                }, new AssignedWorker
                {
                    Name = "Manpreet"
                }, new AssignedWorker
                {
                    Name = "Patrick"
                }, new AssignedWorker
                {
                    Name = "None"
                }
                );
            context.SaveChanges();
        }
        private void seedCrisis(ClientContext context)
        {
            // Update Crisis data
            context.Crises.AddOrUpdate(
                c => c.Type,
                new Crisis
                {
                    Type = "Call"
                }, new Crisis
                {
                    Type = "Accompaniment"
                }, new Crisis
                {
                    Type = "Drop-In"
                }
                );
            context.SaveChanges();
        }
        private void seedDuplicateFiles(ClientContext context)
        {
            context.DuplicateFiles.AddOrUpdate(
                d => d.IsDuplicate,
                new DuplicateFile
                {
                    IsDuplicate = "Yes"
                }, new DuplicateFile
                {
                    IsDuplicate = "null"
                }
                );
            context.SaveChanges();
        }
        private void seedEthnicities(ClientContext context)
        {
            context.Ethnicities.AddOrUpdate(
                e => e.Value,
                new Ethnicity
                {
                    Value = "Indigenous"
                }, new Ethnicity
                {
                    Value = "Asian"
                }, new Ethnicity
                {
                    Value = "Black"
                }, new Ethnicity
                {
                    Value = "Caucasian"
                }, new Ethnicity
                {
                    Value = "Declined"
                }, new Ethnicity
                {
                    Value = "Latin"
                }, new Ethnicity
                {
                    Value = "Middle Eastern"
                }, new Ethnicity
                {
                    Value = "Other"
                }, new Ethnicity
                {
                    Value = "South Asian"
                }, new Ethnicity
                {
                    Value = "South East Asian"
                }
                );
            context.SaveChanges();
        }
        private void seedFamilyViolenceFiles(ClientContext context)
        {
            context.FamilyViolenceFiles.AddOrUpdate(
                f => f.Exists,
                new FamilyViolenceFile
                {
                    Exists = "Yes"
                }, new FamilyViolenceFile
                {
                    Exists = "No"
                }, new FamilyViolenceFile
                {
                    Exists = "N/A"
                }
                );
            context.SaveChanges();
        }
        private void seedIncidents(ClientContext context)
        {
            context.Incidents.AddOrUpdate(
                i => i.Type,
                new Incident
                {
                    Type = "Abduction"
                }, new Incident
                {
                    Type = "Adult Historical Sexual Assault"
                }, new Incident
                {
                    Type = "Adult Sexual Assault"
                }, new Incident
                {
                    Type = "Partner Assault"
                }, new Incident
                {
                    Type = "Attempted Murder"
                }, new Incident
                {
                    Type = "Child Physical Assault"
                }, new Incident
                {
                    Type = "Child Sexual Abuse/Exploitation"
                }, new Incident
                {
                    Type = "Criminal Harassment/Stalking"
                }, new Incident
                {
                    Type = "Elder Abuse"
                }, new Incident
                {
                    Type = "Human Trafficking"
                }, new Incident
                {
                    Type = "Murder"
                }, new Incident
                {
                    Type = "N/A"
                }, new Incident
                {
                    Type = "Other"
                }, new Incident
                {
                    Type = "Other Assault"
                }, new Incident
                {
                    Type = "Other Crime – DV"
                }, new Incident
                {
                    Type = "Other Familial Assault"
                }, new Incident
                {
                    Type = "Threatening"
                }, new Incident
                {
                    Type = "Youth Sexual Assault/Exploitation"
                }
                );
            context.SaveChanges();
        }
        private void seedPrograms(ClientContext context)
        {
            // Populate Program data
            context.Programs.AddOrUpdate(
                p => p.Type,
                new Program
                {
                    Type = "Crisis"
                }, new Program
                {
                    Type = "Court"
                }, new Program
                {
                    Type = "SMART"
                }, new Program
                {
                    Type = "DVU"
                }, new Program
                {
                    Type = "MCFD"
                }
                );
            context.SaveChanges();
        }
        private void seedReferralContacts(ClientContext ctx)
        {
            // Populate ReferralContact data
            ctx.ReferralContacts.AddOrUpdate(
                r => r.Contact,
                new ReferralContact
                {
                    Contact = "PBVS"
                }, new ReferralContact
                {
                    Contact = "MCFD"
                }, new ReferralContact
                {
                    Contact = "VictimLINK"
                }, new ReferralContact
                {
                    Contact = "TH"
                }, new ReferralContact
                {
                    Contact = "Self"
                }, new ReferralContact
                {
                    Contact = "FNS"
                }, new ReferralContact
                {
                    Contact = "Other"
                }, new ReferralContact
                {
                    Contact = "Medical"
                }
                );
            ctx.SaveChanges();
        }
        private void seedReferralSources(ClientContext ctx)
        {
            // Populate Referral Source data
            ctx.ReferralSources.AddOrUpdate(
                r => r.Source,
                new ReferralSource
                {
                    Source = "Community Agency"
                }, new ReferralSource
                {
                    Source = "Family/Friend"
                }, new ReferralSource
                {
                    Source = "Government"
                }, new ReferralSource
                {
                    Source = "CVAP"
                }, new ReferralSource
                {
                    Source = "CBVS"
                }
                );
            ctx.SaveChanges();
        }
        private void seedRepeatClients(ClientContext ctx)
        {
            // Populate Repeat Client data
            ctx.RepeatClients.AddOrUpdate(
                r => r.IsRepeat,
                new RepeatClient
                {
                    IsRepeat = "Yes"
                }, new RepeatClient
                {
                    IsRepeat = "null"
                }
                );
            ctx.SaveChanges();
        }
        private void seedRiskLevels(ClientContext ctx)
        {
            // Populate Risk Level data
            ctx.RiskLevels.AddOrUpdate(
                r => r.Level,
                new RiskLevel
                {
                    Level = "High"
                }, new RiskLevel
                {
                    Level = "DVU"
                },
                new RiskLevel
                {
                    Level = "null"
                }
                );
            ctx.SaveChanges();
        }
        private void seedRiskStatuses(ClientContext ctx)
        {
            // Populate Risk Status data
            ctx.RiskStatuses.AddOrUpdate(
                r => r.Status,
                new RiskStatus
                {
                    Status = "Pending"
                },
                new RiskStatus
                {
                    Status = "Complete"
                }, new RiskStatus
                {
                    Status = "null"
                }
                );
            ctx.SaveChanges();
        }
        private void seedServices(ClientContext ctx)
        {
            // Populate Service data
            ctx.Services.AddOrUpdate(
                s => s.Type,
                new Service
                {
                    Type = "File"
                }, new Service
                {
                    Type = "N/A"
                }
                );
            ctx.SaveChanges();
        }
        private void seedStatusesOfFiles(ClientContext ctx)
        {
            // Populate Status Of File data
            ctx.StatusesOfFiles.AddOrUpdate(
                s => s.Status,
                new StatusOfFile
                {
                    Status = "Reopened"
                }, new StatusOfFile
                {
                    Status = "Closed"
                }, new StatusOfFile
                {
                    Status = "Open"
                }
                );
            ctx.SaveChanges();
        }
        private void seedVictimsOfIncidents(ClientContext ctx)
        {
            // Populate Victim Of Incident data
            ctx.VictimsOfIncidents.AddOrUpdate(
                v => v.Type,
                new VictimOfIncident
                {
                    Type = "Primary"
                }, new VictimOfIncident
                {
                    Type = "Secondary"
                }
                );
            ctx.SaveChanges();
        }
        private void seedYears(ClientContext ctx)
        {
            // Populate Fiscal Year ranges
            ctx.Years.AddOrUpdate(
                y => y.Range,
                new Year
                {
                    Range = "10-11"
                }, new Year
                {
                    Range = "11-12"
                }, new Year
                {
                    Range = "12-13"
                }, new Year
                {
                    Range = "13-14"
                }, new Year
                {
                    Range = "14-15"
                }, new Year
                {
                    Range = "15-16"
                }, new Year
                {
                    Range = "16-17"
                }

            );
            ctx.SaveChanges();
        }
        private void seedClients(ClientContext ctx)
        {
            ctx.Clients.AddOrUpdate(
                c => new { c.FirstName, c.Surname },
                    new Client
                    {
                        Month = 4,
                        Day = 20,
                        Surname = "Gravy",
                        FirstName = "Grits",
                        PoliceFileNumber = "12-12345",
                        CourtFileNumber = 1,
                        SWCFileNumber = 1,

                        YearId = (ctx.Years.Where(c => c.Range == "10-11").FirstOrDefault().YearId),

                        RiskLevelId = (ctx.RiskLevels.Where(c => c.Level == "High").FirstOrDefault().RiskLevelId),

                        CrisisId = (ctx.Crises.Where(c => c.Type == "Call").FirstOrDefault().CrisisId),

                        ServiceId = (ctx.Services.Where(c => c.Type == "File").FirstOrDefault().ServiceId),

                        ProgramId = (ctx.Programs.Where(c => c.Type == "Crisis").FirstOrDefault().ProgramId),

                        AssessmentAssgndTo = "Rudolf the Red",

                        RiskStatusId = (ctx.RiskStatuses.Where(c => c.Status == "Pending").FirstOrDefault().RiskStatusId),

                        AssignedWorkerId = (ctx.AssignedWorkers.Where(c => c.Name == "Manpreet").FirstOrDefault().AssignedWorkerId),

                        ReferralSourceId = (ctx.ReferralSources.Where(c => c.Source == "Community Agency").FirstOrDefault().ReferralSourceId),

                        ReferralContactId = (ctx.ReferralContacts.Where(c => c.Contact == "PBVS").FirstOrDefault().ReferralContactId),

                        IncidentId = (ctx.Incidents.Where(c => c.Type == "Threatening").FirstOrDefault().IncidentId),

                        AbuserSFName = "Doe, Jane",

                        AbuserRelationshipId = (ctx.AbuserRelationships.Where(c => c.Relationship == "Other").FirstOrDefault().AbuserRelationshipId),

                        VictimOfIncidentId = (ctx.VictimsOfIncidents.Where(c => c.Type == "Primary").FirstOrDefault().VictimOfIncidentId),

                        FamilyViolenceFileId = (ctx.FamilyViolenceFiles.Where(c => c.Exists == "No").FirstOrDefault().FamilyViolenceFileId),

                        Gender = 'M',

                        EthnicityId = (ctx.Ethnicities.Where(c => c.Value == "Caucasian").FirstOrDefault().EthnicityId),

                        AgeId = (ctx.Ages.Where(c => c.Range == "Adult >24 <65").FirstOrDefault().AgeId),

                        RepeatClientId = (ctx.RepeatClients.Where(c => c.IsRepeat == "Yes").FirstOrDefault().RepeatClientId),

                        DuplicateFileId = (ctx.DuplicateFiles.Where(c => c.IsDuplicate == "Yes").FirstOrDefault().DuplicateFileId),

                        NumChildrenSevenToTwelve = 0,
                        NumChildrenZeroToSix = 0,

                        StatusOfFileId = (ctx.StatusesOfFiles.Where(c => c.Status == "Closed").FirstOrDefault().StatusOfFileId),

                        DateLastTransferred = new DateTime(2014, 1, 12),
                        DateClosed = new DateTime(2015, 2, 13),
                        DateReOpened = new DateTime(2015, 4, 20)
                    }
                );
            ctx.SaveChanges();
        }


        private void seedSmartLookups(ClientContext ctx)
        {
            ctx.SexExploitations.AddOrUpdate(
                s => s.Value,
                new SexExploitation { Value = "Yes" },
                new SexExploitation { Value = "No" },
                new SexExploitation { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.MultiplePerps.AddOrUpdate(
                m => m.Value,
                new MultiplePerps { Value = "Yes" },
                new MultiplePerps { Value = "No" },
                new MultiplePerps { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.DrugsFacilitated.AddOrUpdate(
                m => m.Value,
                new DrugFacilitated { Value = "Yes" },
                new DrugFacilitated { Value = "No" },
                new DrugFacilitated { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.CitiesOfAssault.AddOrUpdate(
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
            ctx.SaveChanges();

            ctx.CitiesOfResidence.AddOrUpdate(
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
            ctx.SaveChanges();

            ctx.ReferringHospitals.AddOrUpdate(
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
            ctx.SaveChanges();

            ctx.HospitalsAttended.AddOrUpdate(
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
            ctx.SaveChanges();

            ctx.SocialWorkAttendances.AddOrUpdate(
                a => a.Value,
                new SocialWorkAttendance { Value = "Yes" },
                new SocialWorkAttendance { Value = "No" },
                new SocialWorkAttendance { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.PoliceAttendances.AddOrUpdate(
                a => a.Value,
                new PoliceAttendance { Value = "Yes" },
                new PoliceAttendance { Value = "No" },
                new PoliceAttendance { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.VictimServicesAttendances.AddOrUpdate(
                a => a.Value,
                new VictimServicesAttendance { Value = "Yes" },
                new VictimServicesAttendance { Value = "No" },
                new VictimServicesAttendance { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.MedicalOnly.AddOrUpdate(
                m => m.Value,
                new MedicalOnly { Value = "Yes" },
                new MedicalOnly { Value = "No" },
                new MedicalOnly { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.EvidenceStored.AddOrUpdate(
                c => c.EvidenceStoredId,
                new EvidenceStored { Value = "Yes" },
                new EvidenceStored { Value = "No" },
                new EvidenceStored { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.HivMeds.AddOrUpdate(
                c => c.HivMedsId,
                new HivMeds { Value = "Yes" },
                new HivMeds { Value = "No" },
                new HivMeds { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.ReferredToCbvs.AddOrUpdate(
                c => c.ReferredToCbvsId,
                new ReferredToCbvs { Value = "Yes" },
                new ReferredToCbvs { Value = "No" },
                new ReferredToCbvs { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.PoliceReported.AddOrUpdate(
                c => c.PoliceReportedId,
                new PoliceReported { Value = "Yes" },
                new PoliceReported { Value = "No" },
                new PoliceReported { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.ThirdPartyReports.AddOrUpdate(
                c => c.ThirdPartyReportId,
                new ThirdPartyReport { Value = "Yes" },
                new ThirdPartyReport { Value = "No" },
                new ThirdPartyReport { Value = "N/A" }
                );
            ctx.SaveChanges();

            ctx.BadDateReports.AddOrUpdate(
                c => c.BadDateReportId,
                new BadDateReport { IsBadDateReported = "Yes" },
                new BadDateReport { IsBadDateReported = "No" },
                new BadDateReport { IsBadDateReported = "N/A" }
                );
            ctx.SaveChanges();
        }

        private void seedSmartEntity(ClientContext ctx)
        {
            ctx.Smarts.AddOrUpdate(
                c => new { c.NumberTransportsProvided },
                new Smart
                {
                    SmartId = 1,
                    ClientId = (ctx.Clients.Where(c => c.ClientId == 1).FirstOrDefault().ClientId),
                    SexExploitationId = (ctx.SexExploitations.Where(c => c.Value == "Yes").FirstOrDefault().SexExploitationId),
                    MultiplePerpsId = (ctx.MultiplePerps.Where(c => c.Value == "Yes").FirstOrDefault().MultiplePerpsId),
                    DrugFacilitatedId = (ctx.DrugsFacilitated.Where(c => c.Value == "Yes").FirstOrDefault().DrugFacilitatedId),
                    CityOfAssaultId = (ctx.CitiesOfAssault.Where(c => c.Value == "Burnaby").FirstOrDefault().CityOfAssaultId),
                    CityOfResidenceId = (ctx.CitiesOfResidence.Where(c => c.Value == "Burnaby").FirstOrDefault().CityOfResidenceId),

                    AccompanimentMinutes = 5,

                    ReferringHospitalId = (ctx.ReferringHospitals.Where(c => c.Value == "Burnaby Hospital").FirstOrDefault().ReferringHospitalId),

                    HospitalAttendedId = (ctx.HospitalsAttended.Where(c => c.Value == "Burnaby Hospital").FirstOrDefault().HospitalAttendedId),
                    SocialWorkAttendanceId = (ctx.SocialWorkAttendances.Where(c => c.Value == "Yes").FirstOrDefault().SocialWorkAttendanceId),
                    PoliceAttendanceId = (ctx.PoliceAttendances.Where(c => c.Value == "Yes").FirstOrDefault().PoliceAttendanceId),
                    VictimServicesAttendanceId = (ctx.VictimServicesAttendances.Where(c => c.Value == "Yes").FirstOrDefault().VictimServicesAttendanceId),
                    MedicalOnlyId = (ctx.MedicalOnly.Where(c => c.Value == "Yes").FirstOrDefault().MedicalOnlyId),
                    EvidenceStoredId = (ctx.EvidenceStored.Where(c => c.Value == "Yes").FirstOrDefault().EvidenceStoredId),
                    HivMedsId = (ctx.HivMeds.Where(c => c.Value == "Yes").FirstOrDefault().HivMedsId),
                    ReferredToCbvsId = (ctx.ReferredToCbvs.Where(c => c.Value == "Yes").FirstOrDefault().ReferredToCbvsId),
                    PoliceReportedId = (ctx.PoliceReported.Where(c => c.Value == "Yes").FirstOrDefault().PoliceReportedId),
                    ThirdPartyReportId = (ctx.ThirdPartyReports.Where(c => c.Value == "Yes").FirstOrDefault().ThirdPartyReportId),
                    BadDateReportId = (ctx.BadDateReports.Where(c => c.IsBadDateReported == "Yes").FirstOrDefault().BadDateReportId),

                    NumberTransportsProvided = 2,
                    ReferredToNursePracticioner = true
                });
            ctx.SaveChanges();
        }

    }
}
