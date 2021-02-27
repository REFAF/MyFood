namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTypeToIdentityModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "city_id", "dbo.Cities");
            DropForeignKey("dbo.AspNetUsers", "orgType_id", "dbo.OrgTypes");
            DropIndex("dbo.AspNetUsers", new[] { "city_id" });
            DropIndex("dbo.AspNetUsers", new[] { "orgType_id" });
            AddColumn("dbo.AspNetUsers", "userType_id", c => c.Byte(nullable: false));
            CreateIndex("dbo.AspNetUsers", "userType_id");
            AddForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes", "userType_id", cascadeDelete: true);
            DropColumn("dbo.AspNetUsers", "city_id");
            DropColumn("dbo.AspNetUsers", "org_location");
            DropColumn("dbo.AspNetUsers", "orgType_id");
            DropColumn("dbo.AspNetUsers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(maxLength: 50));
            AddColumn("dbo.AspNetUsers", "orgType_id", c => c.Byte());
            AddColumn("dbo.AspNetUsers", "org_location", c => c.String());
            AddColumn("dbo.AspNetUsers", "city_id", c => c.Byte());
            DropForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes");
            DropIndex("dbo.AspNetUsers", new[] { "userType_id" });
            DropColumn("dbo.AspNetUsers", "userType_id");
            CreateIndex("dbo.AspNetUsers", "orgType_id");
            CreateIndex("dbo.AspNetUsers", "city_id");
            AddForeignKey("dbo.AspNetUsers", "orgType_id", "dbo.OrgTypes", "orgType_id");
            AddForeignKey("dbo.AspNetUsers", "city_id", "dbo.Cities", "city_id");
        }
    }
}
