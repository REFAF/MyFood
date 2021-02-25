namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrganizationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        org_id = c.Int(nullable: false),
                        org_name = c.String(maxLength: 50),
                        city_id = c.Byte(),
                        phone_num = c.Int(),
                        org_location = c.String(),
                        orgType_id = c.Byte(),
                    })
                .PrimaryKey(t => t.org_id)
                .ForeignKey("dbo.Cities", t => t.city_id)
                .ForeignKey("dbo.OrgTypes", t => t.orgType_id)
                .Index(t => t.city_id)
                .Index(t => t.orgType_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Organizations", "orgType_id", "dbo.OrgTypes");
            DropForeignKey("dbo.Organizations", "city_id", "dbo.Cities");
            DropIndex("dbo.Organizations", new[] { "orgType_id" });
            DropIndex("dbo.Organizations", new[] { "city_id" });
            DropTable("dbo.Organizations");
        }
    }
}
