namespace goodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Years", t => t.YearId, cascadeDelete: true)
                .Index(t => t.YearId);
            
            CreateTable(
                "dbo.Years",
                c => new
                    {
                        YearId = c.Int(nullable: false, identity: true),
                        Range = c.String(),
                    })
                .PrimaryKey(t => t.YearId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "YearId", "dbo.Years");
            DropIndex("dbo.Clients", new[] { "YearId" });
            DropTable("dbo.Years");
            DropTable("dbo.Clients");
        }
    }
}
