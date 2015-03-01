namespace GoodSamaritan.Migrations.ClientMigrations
{
    using goodSamaritan.Models.Client;
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

        protected override void Seed(goodSamaritan.Models.Client.ClientContext context)
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
                    Relationship = "Ex-Partne"
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

            // Update Duplicate File data
            context.DuplicateFiles.AddOrUpdate(
                d => d.IsDuplicate,
                new DuplicateFile
                {
                    IsDuplicate = "Yes"
                }, new DuplicateFile
                {
                    IsDuplicate = null
                }
                );
            context.SaveChanges();

            // Update Ethnicity data
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

            // Populate Family Violence Files data
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

            // Populate Incident data
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

            // Populate ReferralContact data
            context.ReferralContacts.AddOrUpdate(
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
            context.SaveChanges();

            // Populate Referral Source data
            context.ReferralSources.AddOrUpdate(
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
            context.SaveChanges();

            // Populate Repeat Client data
            context.RepeatClients.AddOrUpdate(
                r => r.IsRepeat,
                new RepeatClient
                {
                    IsRepeat = "Yes"
                }, new RepeatClient
                {
                    IsRepeat = null
                }
                );
            context.SaveChanges();

            // Populate Risk Level data
            context.RiskLevels.AddOrUpdate(
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
                    Level = null
                }
                );
            context.SaveChanges();

            // Populate Risk Status data
            context.RiskStatuses.AddOrUpdate(
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
                    Status = null
                }
                );
            context.SaveChanges();

            // Populate Service data
            context.Services.AddOrUpdate(
                s => s.Type,
                new Service
                {
                    Type = "File"
                }, new Service
                {
                    Type = "N/A"
                }
                );
            context.SaveChanges();

            // Populate Status Of File data
            context.StatusesOfFiles.AddOrUpdate(
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
            context.SaveChanges();

            // Populate Victim Of Incident data
            context.VictimsOfIncidents.AddOrUpdate(
                v => v.Type,
                new VictimOfIncident
                {
                    Type = "Primary"
                }, new VictimOfIncident
                {
                    Type = "Secondary"
                }
                );
            context.SaveChanges();

            // Populate Fiscal Year ranges
            context.Years.AddOrUpdate(
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
            context.SaveChanges();

            // Add sample Clients
            context.Clients.AddOrUpdate(
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

                        YearId = (context.Years.Where(c => c.Range == "10-11").FirstOrDefault().YearId),

                        RiskLevelId = (context.RiskLevels.Where(c => c.Level == "High").FirstOrDefault().RiskLevelId),

                        CrisisId = (context.Crises.Where(c => c.Type == "Call").FirstOrDefault().CrisisId),

                        ServiceId = (context.Services.Where(c => c.Type == "File").FirstOrDefault().ServiceId),

                        ProgramId = (context.Programs.Where(c => c.Type == "Crisis").FirstOrDefault().ProgramId),

                        AssessmentAssgndTo = "Rudolf the Red",

                        RiskStatusId = (context.RiskStatuses.Where(c => c.Status == "Pending").FirstOrDefault().RiskStatusId),

                        AssignedWorkerId = (context.AssignedWorkers.Where(c => c.Name == "Manpreet").FirstOrDefault().AssignedWorkerId),

                        ReferralSourceId = (context.ReferralSources.Where(c => c.Source == "Community Agency").FirstOrDefault().ReferralSourceId),

                        ReferralContactId = (context.ReferralContacts.Where(c => c.Contact == "PBVS").FirstOrDefault().ReferralContactId),

                        IncidentId = (context.Incidents.Where(c => c.Type == "Threatening").FirstOrDefault().IncidentId),

                        AbuserSFName = "Doe, Jane",

                        AbuserRelationshipId = (context.AbuserRelationships.Where(c => c.Relationship == "Other").FirstOrDefault().AbuserRelationshipId),

                        VictimOfIncidentId = (context.VictimsOfIncidents.Where(c => c.Type == "Primary").FirstOrDefault().VictimOfIncidentId),

                        FamilyViolenceFildeId = (context.FamilyViolenceFiles.Where(c => c.Exists == "N/A").FirstOrDefault().FamilyViolenceFileId),

                        Gender = 'M',

                        EthnicityId = (context.Ethnicities.Where(c => c.Value == "Caucasian").FirstOrDefault().EthnicityId),

                        AgeId = (context.Ages.Where(c => c.Range == "Adult >24 <65").FirstOrDefault().AgeId),

                        RepeatClientId = (context.RepeatClients.Where(c => c.IsRepeat == "Yes").FirstOrDefault().RepeatClientId),

                        DuplicateFileId = (context.DuplicateFiles.Where(c => c.IsDuplicate == "Yes").FirstOrDefault().DuplicateFileId),

                        NumChildrenSevenToTwelve = 0,
                        NumChildrenZeroToSix = 0,

                        StatusOfFileId = (context.StatusesOfFiles.Where(c => c.Status == "Closed").FirstOrDefault().StatusOfFileId),

                        DateLastTransferred = new DateTime(2014, 1, 12),
                        DateClosed = new DateTime(2015, 2, 13),
                        DateReOpened = new DateTime(2015, 4, 20)
                    }
                );
            context.SaveChanges();

        }
    }
}
