namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "event_date", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "event_date");
        }
    }
}
