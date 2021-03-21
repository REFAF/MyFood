namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "order_status", c => c.String());
            DropColumn("dbo.Orders", "Accept");
            DropColumn("dbo.Orders", "Deny");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Deny", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Accept", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "order_status");
        }
    }
}
