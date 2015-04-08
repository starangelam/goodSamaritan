namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixBugInSmarts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendance_VictimServicesAttendanceId" });
            RenameColumn(table: "dbo.Smarts", name: "VictimServicesAttendance_VictimServicesAttendanceId", newName: "VictimServicesAttendanceId");
            AlterColumn("dbo.Smarts", "VictimServicesAttendanceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Smarts", "VictimServicesAttendanceId");
            AddForeignKey("dbo.Smarts", "VictimServicesAttendanceId", "dbo.VictimServicesAttendances", "VictimServicesAttendanceId", cascadeDelete: true);
            DropColumn("dbo.Smarts", "VictimServiceAttendanceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Smarts", "VictimServiceAttendanceId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Smarts", "VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendanceId" });
            AlterColumn("dbo.Smarts", "VictimServicesAttendanceId", c => c.Int());
            RenameColumn(table: "dbo.Smarts", name: "VictimServicesAttendanceId", newName: "VictimServicesAttendance_VictimServicesAttendanceId");
            CreateIndex("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId");
            AddForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances", "VictimServicesAttendanceId");
        }
    }
}
