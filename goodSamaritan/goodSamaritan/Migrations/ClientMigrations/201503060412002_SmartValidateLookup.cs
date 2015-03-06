namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartValidateLookup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BadDateReports", "IsBadDateReported", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CityOfAssaults", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.CityOfResidences", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.DrugFacilitateds", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.EvidenceStoreds", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.HivMeds", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.HospitalAttendeds", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.MedicalOnlies", "Value", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.MultiplePerps", "Value", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.BadDateReports", "Value");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BadDateReports", "Value", c => c.String());
            AlterColumn("dbo.MultiplePerps", "Value", c => c.String());
            AlterColumn("dbo.MedicalOnlies", "Value", c => c.String());
            AlterColumn("dbo.HospitalAttendeds", "Value", c => c.String());
            AlterColumn("dbo.HivMeds", "Value", c => c.String());
            AlterColumn("dbo.EvidenceStoreds", "Value", c => c.String());
            AlterColumn("dbo.DrugFacilitateds", "Value", c => c.String());
            AlterColumn("dbo.CityOfResidences", "Value", c => c.String());
            AlterColumn("dbo.CityOfAssaults", "Value", c => c.String());
            DropColumn("dbo.BadDateReports", "IsBadDateReported");
        }
    }
}
