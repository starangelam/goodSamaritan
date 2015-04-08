namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allowNullableDatesInClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "DateLastTransferred", c => c.DateTime());
            AlterColumn("dbo.Clients", "DateClosed", c => c.DateTime());
            AlterColumn("dbo.Clients", "DateReOpened", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "DateReOpened", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "DateClosed", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "DateLastTransferred", c => c.DateTime(nullable: false));
        }
    }
}
