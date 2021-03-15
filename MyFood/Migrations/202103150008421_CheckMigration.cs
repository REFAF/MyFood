namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "unit_name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "unit_name");
        }
    }
}
