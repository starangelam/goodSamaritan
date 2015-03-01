namespace goodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedto : DbMigration
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
            
            AddColumn("dbo.Clients", "RiskLevelId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "CrisisId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "ServiceId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "ProgramId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "AssessmentAssgndTo", c => c.String());
            AddColumn("dbo.Clients", "RiskStatusId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "AssignedWorkerId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "ReferralSourceId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "ReferralContactId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "IncidentId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "AbuserSFName", c => c.String());
            AddColumn("dbo.Clients", "AbuserRelationshipId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "VictimOfIncidentId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "FamilyViolenceFildeId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "EthnicityId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "AgeId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "RepeatClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "DuplicateFileId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "NumChildrenZeroToSix", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "NumChildrenSevenToTwelve", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "StatusOfFileId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "DateLastTransferred", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "DateClosed", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "DateReOpened", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId", c => c.Int());
            CreateIndex("dbo.Clients", "RiskLevelId");
            CreateIndex("dbo.Clients", "CrisisId");
            CreateIndex("dbo.Clients", "ServiceId");
            CreateIndex("dbo.Clients", "ProgramId");
            CreateIndex("dbo.Clients", "RiskStatusId");
            CreateIndex("dbo.Clients", "AssignedWorkerId");
            CreateIndex("dbo.Clients", "ReferralSourceId");
            CreateIndex("dbo.Clients", "ReferralContactId");
            CreateIndex("dbo.Clients", "IncidentId");
            CreateIndex("dbo.Clients", "AbuserRelationshipId");
            CreateIndex("dbo.Clients", "VictimOfIncidentId");
            CreateIndex("dbo.Clients", "EthnicityId");
            CreateIndex("dbo.Clients", "AgeId");
            CreateIndex("dbo.Clients", "RepeatClientId");
            CreateIndex("dbo.Clients", "DuplicateFileId");
            CreateIndex("dbo.Clients", "StatusOfFileId");
            CreateIndex("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId");
            AddForeignKey("dbo.Clients", "AbuserRelationshipId", "dbo.AbuserRelationships", "AbuserRelationshipId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "AgeId", "dbo.Ages", "AgeId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "AssignedWorkerId", "dbo.AssignedWorkers", "AssignedWorkerId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "CrisisId", "dbo.Crises", "CrisisId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "DuplicateFileId", "dbo.DuplicateFiles", "DuplicateFileId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities", "EthnicityId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId", "dbo.FamilyViolenceFiles", "FamilyViolenceFileId");
            AddForeignKey("dbo.Clients", "IncidentId", "dbo.Incidents", "IncidentId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ProgramId", "dbo.Programs", "ProgramId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ReferralContactId", "dbo.ReferralContacts", "ReferralContactId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ReferralSourceId", "dbo.ReferralSources", "ReferralSourceId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "RepeatClientId", "dbo.RepeatClients", "RepeatClientId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "RiskLevelId", "dbo.RiskLevels", "RiskLevelId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "RiskStatusId", "dbo.RiskStatus", "RiskStatusId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ServiceId", "dbo.Services", "ServiceId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "StatusOfFileId", "dbo.StatusOfFiles", "StatusOfFileId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "VictimOfIncidentId", "dbo.VictimOfIncidents", "VictimOfIncidentId", cascadeDelete: true);
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
            DropColumn("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId");
            DropColumn("dbo.Clients", "DateReOpened");
            DropColumn("dbo.Clients", "DateClosed");
            DropColumn("dbo.Clients", "DateLastTransferred");
            DropColumn("dbo.Clients", "StatusOfFileId");
            DropColumn("dbo.Clients", "NumChildrenSevenToTwelve");
            DropColumn("dbo.Clients", "NumChildrenZeroToSix");
            DropColumn("dbo.Clients", "DuplicateFileId");
            DropColumn("dbo.Clients", "RepeatClientId");
            DropColumn("dbo.Clients", "AgeId");
            DropColumn("dbo.Clients", "EthnicityId");
            DropColumn("dbo.Clients", "FamilyViolenceFildeId");
            DropColumn("dbo.Clients", "VictimOfIncidentId");
            DropColumn("dbo.Clients", "AbuserRelationshipId");
            DropColumn("dbo.Clients", "AbuserSFName");
            DropColumn("dbo.Clients", "IncidentId");
            DropColumn("dbo.Clients", "ReferralContactId");
            DropColumn("dbo.Clients", "ReferralSourceId");
            DropColumn("dbo.Clients", "AssignedWorkerId");
            DropColumn("dbo.Clients", "RiskStatusId");
            DropColumn("dbo.Clients", "AssessmentAssgndTo");
            DropColumn("dbo.Clients", "ProgramId");
            DropColumn("dbo.Clients", "ServiceId");
            DropColumn("dbo.Clients", "CrisisId");
            DropColumn("dbo.Clients", "RiskLevelId");
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
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.Crises");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
