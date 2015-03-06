namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allowNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "CourtFileNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "CourtFileNumber", c => c.Int(nullable: false));
        }
    }
}
