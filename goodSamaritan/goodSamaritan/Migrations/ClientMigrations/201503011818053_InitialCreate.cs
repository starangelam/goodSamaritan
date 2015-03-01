namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        Relationship = c.String(),
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
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        SWCFileNumber = c.Int(nullable: false),
                        RiskLevelId = c.Int(nullable: false),
                        CrisisId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        AssessmentAssgndTo = c.String(),
                        RiskStatusId = c.Int(nullable: false),
                        AssignedWorkerId = c.Int(nullable: false),
                        ReferralSourceId = c.Int(nullable: false),
                        ReferralContactId = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                        AbuserSFName = c.String(),
                        AbuserRelationshipId = c.Int(nullable: false),
                        VictimOfIncidentId = c.Int(nullable: false),
                        FamilyViolenceFildeId = c.Int(nullable: false),
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
                        FamilyViolenceFile_FamilyViolenceFileId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.Ages", t => t.AgeId, cascadeDelete: true)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorkerId, cascadeDelete: true)
                .ForeignKey("dbo.Crises", t => t.CrisisId, cascadeDelete: true)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFileId, cascadeDelete: true)
                .ForeignKey("dbo.Ethnicities", t => t.EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFile_FamilyViolenceFileId)
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
                .Index(t => t.EthnicityId)
                .Index(t => t.AgeId)
                .Index(t => t.RepeatClientId)
                .Index(t => t.DuplicateFileId)
                .Index(t => t.StatusOfFileId)
                .Index(t => t.FamilyViolenceFile_FamilyViolenceFileId);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Range = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkers",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFiles",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        IsDuplicate = c.String(),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.FamilyViolenceFiles",
                c => new
                    {
                        FamilyViolenceFileId = c.Int(nullable: false, identity: true),
                        Exists = c.String(),
                    })
                .PrimaryKey(t => t.FamilyViolenceFileId);
            
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        Range = c.String(),
                    })
                .PrimaryKey(t => t.YearId);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
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
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClients",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        IsRepeat = c.String(),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
            CreateTable(
                "dbo.RiskLevels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatus",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.StatusOfFiles",
                c => new
                    {
                        StatusOfFileId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.StatusOfFileId);
            
            CreateTable(
                "dbo.VictimOfIncidents",
                c => new
                    {
                        VictimOfIncidentId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.VictimOfIncidentId);
            
        }
        
        public override void Down()
        {
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
            DropForeignKey("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "DuplicateFileId", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "CrisisId", "dbo.Crises");
            DropForeignKey("dbo.Clients", "AssignedWorkerId", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "AgeId", "dbo.Ages");
            DropForeignKey("dbo.Clients", "AbuserRelationshipId", "dbo.AbuserRelationships");
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFile_FamilyViolenceFileId" });
            DropIndex("dbo.Clients", new[] { "StatusOfFileId" });
            DropIndex("dbo.Clients", new[] { "DuplicateFileId" });
            DropIndex("dbo.Clients", new[] { "RepeatClientId" });
            DropIndex("dbo.Clients", new[] { "AgeId" });
            DropIndex("dbo.Clients", new[] { "EthnicityId" });
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
