namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Accept", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Orders", "Deny", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Deny", c => c.Boolean());
            AlterColumn("dbo.Orders", "Accept", c => c.Boolean());
        }
    }
}
