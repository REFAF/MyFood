namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Accept", c => c.Boolean());
            AddColumn("dbo.Orders", "Deny", c => c.Boolean());
            DropColumn("dbo.Orders", "Done");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Done", c => c.Boolean());
            DropColumn("dbo.Orders", "Deny");
            DropColumn("dbo.Orders", "Accept");
        }
    }
}
