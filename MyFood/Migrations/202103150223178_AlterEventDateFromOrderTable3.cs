namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterEventDateFromOrderTable3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "event_date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "event_date", c => c.DateTime(storeType: "date"));
        }
    }
}
