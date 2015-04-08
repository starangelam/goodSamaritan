namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addConstraintsToClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "PoliceFileNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "PoliceFileNumber", c => c.String(maxLength: 24));
        }
    }
}
