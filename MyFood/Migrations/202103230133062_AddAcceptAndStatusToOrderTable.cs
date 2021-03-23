namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAcceptAndStatusToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "accept", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "accept");
        }
    }
}
