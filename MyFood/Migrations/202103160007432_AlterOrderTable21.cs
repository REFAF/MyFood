namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "event_date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "event_date", c => c.DateTime(storeType: "date"));
        }
    }
}
