namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCityTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Donators", "city_id", "dbo.Cities");
            DropForeignKey("dbo.Organizations", "city_id", "dbo.Cities");
            DropIndex("dbo.Donators", new[] { "city_id" });
            DropIndex("dbo.Organizations", new[] { "city_id" });
            DropTable("dbo.Cities");
            DropTable("dbo.Donators");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Donators",
                c => new
                    {
                        donator_id = c.Long(nullable: false),
                        name = c.String(maxLength: 30),
                        mobile = c.String(maxLength: 10),
                        city_id = c.Byte(),
                    })
                .PrimaryKey(t => t.donator_id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        city_id = c.Byte(nullable: false, identity: true),
                        city_name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.city_id);
            
            CreateIndex("dbo.Organizations", "city_id");
            CreateIndex("dbo.Donators", "city_id");
            AddForeignKey("dbo.Organizations", "city_id", "dbo.Cities", "city_id");
            AddForeignKey("dbo.Donators", "city_id", "dbo.Cities", "city_id");
        }
    }
}
