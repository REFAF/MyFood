namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrgInfoToIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "city_id", c => c.Byte());
            AddColumn("dbo.AspNetUsers", "org_location", c => c.String());
            AddColumn("dbo.AspNetUsers", "orgType_id", c => c.Byte());
            CreateIndex("dbo.AspNetUsers", "city_id");
            CreateIndex("dbo.AspNetUsers", "orgType_id");
            AddForeignKey("dbo.AspNetUsers", "city_id", "dbo.Cities", "city_id");
            AddForeignKey("dbo.AspNetUsers", "orgType_id", "dbo.OrgTypes", "orgType_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "orgType_id", "dbo.OrgTypes");
            DropForeignKey("dbo.AspNetUsers", "city_id", "dbo.Cities");
            DropIndex("dbo.AspNetUsers", new[] { "orgType_id" });
            DropIndex("dbo.AspNetUsers", new[] { "city_id" });
            DropColumn("dbo.AspNetUsers", "orgType_id");
            DropColumn("dbo.AspNetUsers", "org_location");
            DropColumn("dbo.AspNetUsers", "city_id");
        }
    }
}
