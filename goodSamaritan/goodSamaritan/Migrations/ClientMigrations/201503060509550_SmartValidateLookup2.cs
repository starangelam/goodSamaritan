namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartValidateLookup2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PoliceAttendances", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.PoliceReporteds", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ReferredToCbvs", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ReferringHospitals", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.SexExploitations", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.SocialWorkAttendances", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ThirdPartyReports", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.VictimServicesAttendances", "Value", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VictimServicesAttendances", "Value", c => c.String());
            AlterColumn("dbo.ThirdPartyReports", "Value", c => c.String());
            AlterColumn("dbo.SocialWorkAttendances", "Value", c => c.String());
            AlterColumn("dbo.SexExploitations", "Value", c => c.String());
            AlterColumn("dbo.ReferringHospitals", "Value", c => c.String());
            AlterColumn("dbo.ReferredToCbvs", "Value", c => c.String());
            AlterColumn("dbo.PoliceReporteds", "Value", c => c.String());
            AlterColumn("dbo.PoliceAttendances", "Value", c => c.String());
        }
    }
}
