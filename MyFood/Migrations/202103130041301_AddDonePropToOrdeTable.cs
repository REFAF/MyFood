namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDonePropToOrdeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Done");
        }
    }
}
