namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterEventTimeInOrder2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "event_time", c => c.Time(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "event_time", c => c.DateTime());
        }
    }
}
