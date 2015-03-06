namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientInitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        Relationship = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.AbuserRelationshipId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        YearId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        PoliceFileNumber = c.String(maxLength: 24),
                        CourtFileNumber = c.Int(nullable: false),
                        SWCFileNumber = c.Int(nullable: false),
                        RiskLevelId = c.Int(nullable: false),
                        CrisisId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        AssessmentAssgndTo = c.String(nullable: false, maxLength: 64),
                        RiskStatusId = c.Int(nullable: false),
                        AssignedWorkerId = c.Int(nullable: false),
                        ReferralSourceId = c.Int(nullable: false),
                        ReferralContactId = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                        AbuserSFName = c.String(nullable: false, maxLength: 64),
                        AbuserRelationshipId = c.Int(nullable: false),
                        VictimOfIncidentId = c.Int(nullable: false),
                        FamilyViolenceFileId = c.Int(nullable: false),
                        EthnicityId = c.Int(nullable: false),
                        AgeId = c.Int(nullable: false),
                        RepeatClientId = c.Int(nullable: false),
                        DuplicateFileId = c.Int(nullable: false),
                        NumChildrenZeroToSix = c.Int(nullable: false),
                        NumChildrenSevenToTwelve = c.Int(nullable: false),
                        StatusOfFileId = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReOpened = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.Ages", t => t.AgeId, cascadeDelete: true)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorkerId, cascadeDelete: true)
                .ForeignKey("dbo.Crises", t => t.CrisisId, cascadeDelete: true)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFileId, cascadeDelete: true)
                .ForeignKey("dbo.Ethnicities", t => t.EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFileId, cascadeDelete: true)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: true)
                .ForeignKey("dbo.Incidents", t => t.IncidentId, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralContacts", t => t.ReferralContactId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralSources", t => t.ReferralSourceId, cascadeDelete: true)
                .ForeignKey("dbo.RepeatClients", t => t.RepeatClientId, cascadeDelete: true)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevelId, cascadeDelete: true)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.StatusOfFiles", t => t.StatusOfFileId, cascadeDelete: true)
                .ForeignKey("dbo.VictimOfIncidents", t => t.VictimOfIncidentId, cascadeDelete: true)
                .Index(t => t.YearId)
                .Index(t => t.RiskLevelId)
                .Index(t => t.CrisisId)
                .Index(t => t.ServiceId)
                .Index(t => t.ProgramId)
                .Index(t => t.RiskStatusId)
                .Index(t => t.AssignedWorkerId)
                .Index(t => t.ReferralSourceId)
                .Index(t => t.ReferralContactId)
                .Index(t => t.IncidentId)
                .Index(t => t.AbuserRelationshipId)
                .Index(t => t.VictimOfIncidentId)
                .Index(t => t.FamilyViolenceFileId)
                .Index(t => t.EthnicityId)
                .Index(t => t.AgeId)
                .Index(t => t.RepeatClientId)
                .Index(t => t.DuplicateFileId)
                .Index(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Range = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkers",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFiles",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        IsDuplicate = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.FamilyViolenceFiles",
                c => new
                    {
                        FamilyViolenceFileId = c.Int(nullable: false, identity: true),
                        Exists = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.FamilyViolenceFileId);
            
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        Range = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.YearId);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.ReferralContacts",
                c => new
                    {
                        ReferralContactId = c.Int(nullable: false, identity: true),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.ReferralContactId);
            
            CreateTable(
                "dbo.ReferralSources",
                c => new
                    {
                        ReferralSourceId = c.Int(nullable: false, identity: true),
                        Source = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClients",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        IsRepeat = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
            CreateTable(
                "dbo.RiskLevels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        Level = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatus",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.StatusOfFiles",
                c => new
                    {
                        StatusOfFileId = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.VictimOfIncidents",
                c => new
                    {
                        VictimOfIncidentId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.VictimOfIncidentId);
            
            CreateTable(
                "dbo.BadDateReports",
                c => new
                    {
                        BadDateReportId = c.Int(nullable: false, identity: true),
                        IsBadDateReported = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.Smarts",
                c => new
                    {
                        SmartId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        SexExploitationId = c.Int(nullable: false),
                        MultiplePerpsId = c.Int(nullable: false),
                        DrugFacilitatedId = c.Int(nullable: false),
                        CityOfAssaultId = c.Int(nullable: false),
                        CityOfResidenceId = c.Int(nullable: false),
                        AccompanimentMinutes = c.Int(nullable: false),
                        ReferringHospitalId = c.Int(nullable: false),
                        HospitalAttendedId = c.Int(nullable: false),
                        SocialWorkAttendanceId = c.Int(nullable: false),
                        PoliceAttendanceId = c.Int(nullable: false),
                        VictimServiceAttendanceId = c.Int(nullable: false),
                        MedicalOnlyId = c.Int(nullable: false),
                        EvidenceStoredId = c.Int(nullable: false),
                        HivMedsId = c.Int(nullable: false),
                        ReferredToCbvsId = c.Int(nullable: false),
                        PoliceReportedId = c.Int(nullable: false),
                        ThirdPartyReportId = c.Int(nullable: false),
                        BadDateReportId = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNursePracticioner = c.Boolean(nullable: false),
                        VictimServicesAttendance_VictimServicesAttendanceId = c.Int(),
                    })
                .PrimaryKey(t => t.SmartId)
                .ForeignKey("dbo.BadDateReports", t => t.BadDateReportId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfAssaults", t => t.CityOfAssaultId, cascadeDelete: true)
                .ForeignKey("dbo.CityOfResidences", t => t.CityOfResidenceId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.DrugFacilitateds", t => t.DrugFacilitatedId, cascadeDelete: true)
                .ForeignKey("dbo.EvidenceStoreds", t => t.EvidenceStoredId, cascadeDelete: true)
                .ForeignKey("dbo.HivMeds", t => t.HivMedsId, cascadeDelete: true)
                .ForeignKey("dbo.HospitalAttendeds", t => t.HospitalAttendedId, cascadeDelete: true)
                .ForeignKey("dbo.MedicalOnlies", t => t.MedicalOnlyId, cascadeDelete: true)
                .ForeignKey("dbo.MultiplePerps", t => t.MultiplePerpsId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceAttendances", t => t.PoliceAttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.PoliceReporteds", t => t.PoliceReportedId, cascadeDelete: true)
                .ForeignKey("dbo.ReferredToCbvs", t => t.ReferredToCbvsId, cascadeDelete: true)
                .ForeignKey("dbo.ReferringHospitals", t => t.ReferringHospitalId, cascadeDelete: true)
                .ForeignKey("dbo.SexExploitations", t => t.SexExploitationId, cascadeDelete: true)
                .ForeignKey("dbo.SocialWorkAttendances", t => t.SocialWorkAttendanceId, cascadeDelete: true)
                .ForeignKey("dbo.ThirdPartyReports", t => t.ThirdPartyReportId, cascadeDelete: true)
                .ForeignKey("dbo.VictimServicesAttendances", t => t.VictimServicesAttendance_VictimServicesAttendanceId)
                .Index(t => t.ClientId)
                .Index(t => t.SexExploitationId)
                .Index(t => t.MultiplePerpsId)
                .Index(t => t.DrugFacilitatedId)
                .Index(t => t.CityOfAssaultId)
                .Index(t => t.CityOfResidenceId)
                .Index(t => t.ReferringHospitalId)
                .Index(t => t.HospitalAttendedId)
                .Index(t => t.SocialWorkAttendanceId)
                .Index(t => t.PoliceAttendanceId)
                .Index(t => t.MedicalOnlyId)
                .Index(t => t.EvidenceStoredId)
                .Index(t => t.HivMedsId)
                .Index(t => t.ReferredToCbvsId)
                .Index(t => t.PoliceReportedId)
                .Index(t => t.ThirdPartyReportId)
                .Index(t => t.BadDateReportId)
                .Index(t => t.VictimServicesAttendance_VictimServicesAttendanceId);
            
            CreateTable(
                "dbo.CityOfAssaults",
                c => new
                    {
                        CityOfAssaultId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CityOfAssaultId);
            
            CreateTable(
                "dbo.CityOfResidences",
                c => new
                    {
                        CityOfResidenceId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CityOfResidenceId);
            
            CreateTable(
                "dbo.DrugFacilitateds",
                c => new
                    {
                        DrugFacilitatedId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.DrugFacilitatedId);
            
            CreateTable(
                "dbo.EvidenceStoreds",
                c => new
                    {
                        EvidenceStoredId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.EvidenceStoredId);
            
            CreateTable(
                "dbo.HivMeds",
                c => new
                    {
                        HivMedsId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.HivMedsId);
            
            CreateTable(
                "dbo.HospitalAttendeds",
                c => new
                    {
                        HospitalAttendedId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.HospitalAttendedId);
            
            CreateTable(
                "dbo.MedicalOnlies",
                c => new
                    {
                        MedicalOnlyId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.MedicalOnlyId);
            
            CreateTable(
                "dbo.MultiplePerps",
                c => new
                    {
                        MultiplePerpsId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.MultiplePerpsId);
            
            CreateTable(
                "dbo.PoliceAttendances",
                c => new
                    {
                        PoliceAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.PoliceAttendanceId);
            
            CreateTable(
                "dbo.PoliceReporteds",
                c => new
                    {
                        PoliceReportedId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.PoliceReportedId);
            
            CreateTable(
                "dbo.ReferredToCbvs",
                c => new
                    {
                        ReferredToCbvsId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ReferredToCbvsId);
            
            CreateTable(
                "dbo.ReferringHospitals",
                c => new
                    {
                        ReferringHospitalId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ReferringHospitalId);
            
            CreateTable(
                "dbo.SexExploitations",
                c => new
                    {
                        SexExploitationId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.SexExploitationId);
            
            CreateTable(
                "dbo.SocialWorkAttendances",
                c => new
                    {
                        SocialWorkAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.SocialWorkAttendanceId);
            
            CreateTable(
                "dbo.ThirdPartyReports",
                c => new
                    {
                        ThirdPartyReportId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ThirdPartyReportId);
            
            CreateTable(
                "dbo.VictimServicesAttendances",
                c => new
                    {
                        VictimServicesAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.VictimServicesAttendanceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropForeignKey("dbo.Smarts", "ThirdPartyReportId", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendanceId", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "SexExploitationId", "dbo.SexExploitations");
            DropForeignKey("dbo.Smarts", "ReferringHospitalId", "dbo.ReferringHospitals");
            DropForeignKey("dbo.Smarts", "ReferredToCbvsId", "dbo.ReferredToCbvs");
            DropForeignKey("dbo.Smarts", "PoliceReportedId", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendanceId", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiplePerpsId", "dbo.MultiplePerps");
            DropForeignKey("dbo.Smarts", "MedicalOnlyId", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttendedId", "dbo.HospitalAttendeds");
            DropForeignKey("dbo.Smarts", "HivMedsId", "dbo.HivMeds");
            DropForeignKey("dbo.Smarts", "EvidenceStoredId", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugFacilitatedId", "dbo.DrugFacilitateds");
            DropForeignKey("dbo.Smarts", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Smarts", "CityOfResidenceId", "dbo.CityOfResidences");
            DropForeignKey("dbo.Smarts", "CityOfAssaultId", "dbo.CityOfAssaults");
            DropForeignKey("dbo.Smarts", "BadDateReportId", "dbo.BadDateReports");
            DropForeignKey("dbo.Clients", "VictimOfIncidentId", "dbo.VictimOfIncidents");
            DropForeignKey("dbo.Clients", "StatusOfFileId", "dbo.StatusOfFiles");
            DropForeignKey("dbo.Clients", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatusId", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevelId", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "RepeatClientId", "dbo.RepeatClients");
            DropForeignKey("dbo.Clients", "ReferralSourceId", "dbo.ReferralSources");
            DropForeignKey("dbo.Clients", "ReferralContactId", "dbo.ReferralContacts");
            DropForeignKey("dbo.Clients", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Clients", "IncidentId", "dbo.Incidents");
            DropForeignKey("dbo.Clients", "YearId", "dbo.Years");
            DropForeignKey("dbo.Clients", "FamilyViolenceFileId", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "DuplicateFileId", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "CrisisId", "dbo.Crises");
            DropForeignKey("dbo.Clients", "AssignedWorkerId", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "AgeId", "dbo.Ages");
            DropForeignKey("dbo.Clients", "AbuserRelationshipId", "dbo.AbuserRelationships");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendance_VictimServicesAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "BadDateReportId" });
            DropIndex("dbo.Smarts", new[] { "ThirdPartyReportId" });
            DropIndex("dbo.Smarts", new[] { "PoliceReportedId" });
            DropIndex("dbo.Smarts", new[] { "ReferredToCbvsId" });
            DropIndex("dbo.Smarts", new[] { "HivMedsId" });
            DropIndex("dbo.Smarts", new[] { "EvidenceStoredId" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnlyId" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttendedId" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospitalId" });
            DropIndex("dbo.Smarts", new[] { "CityOfResidenceId" });
            DropIndex("dbo.Smarts", new[] { "CityOfAssaultId" });
            DropIndex("dbo.Smarts", new[] { "DrugFacilitatedId" });
            DropIndex("dbo.Smarts", new[] { "MultiplePerpsId" });
            DropIndex("dbo.Smarts", new[] { "SexExploitationId" });
            DropIndex("dbo.Smarts", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "StatusOfFileId" });
            DropIndex("dbo.Clients", new[] { "DuplicateFileId" });
            DropIndex("dbo.Clients", new[] { "RepeatClientId" });
            DropIndex("dbo.Clients", new[] { "AgeId" });
            DropIndex("dbo.Clients", new[] { "EthnicityId" });
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFileId" });
            DropIndex("dbo.Clients", new[] { "VictimOfIncidentId" });
            DropIndex("dbo.Clients", new[] { "AbuserRelationshipId" });
            DropIndex("dbo.Clients", new[] { "IncidentId" });
            DropIndex("dbo.Clients", new[] { "ReferralContactId" });
            DropIndex("dbo.Clients", new[] { "ReferralSourceId" });
            DropIndex("dbo.Clients", new[] { "AssignedWorkerId" });
            DropIndex("dbo.Clients", new[] { "RiskStatusId" });
            DropIndex("dbo.Clients", new[] { "ProgramId" });
            DropIndex("dbo.Clients", new[] { "ServiceId" });
            DropIndex("dbo.Clients", new[] { "CrisisId" });
            DropIndex("dbo.Clients", new[] { "RiskLevelId" });
            DropIndex("dbo.Clients", new[] { "YearId" });
            DropTable("dbo.VictimServicesAttendances");
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.SexExploitations");
            DropTable("dbo.ReferringHospitals");
            DropTable("dbo.ReferredToCbvs");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerps");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.HospitalAttendeds");
            DropTable("dbo.HivMeds");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugFacilitateds");
            DropTable("dbo.CityOfResidences");
            DropTable("dbo.CityOfAssaults");
            DropTable("dbo.Smarts");
            DropTable("dbo.BadDateReports");
            DropTable("dbo.VictimOfIncidents");
            DropTable("dbo.StatusOfFiles");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.RepeatClients");
            DropTable("dbo.ReferralSources");
            DropTable("dbo.ReferralContacts");
            DropTable("dbo.Programs");
            DropTable("dbo.Incidents");
            DropTable("dbo.Years");
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.Crises");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.Clients");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
