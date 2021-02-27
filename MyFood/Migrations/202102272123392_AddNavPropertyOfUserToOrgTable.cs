namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNavPropertyOfUserToOrgTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Organizations", "Id");
            AddForeignKey("dbo.Organizations", "Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Organizations", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Organizations", new[] { "Id" });
            DropColumn("dbo.Organizations", "Id");
        }
    }
}
