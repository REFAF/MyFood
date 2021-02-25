namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDonatorTable : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.donator_id)
                .ForeignKey("dbo.Cities", t => t.city_id)
                .Index(t => t.city_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donators", "city_id", "dbo.Cities");
            DropIndex("dbo.Donators", new[] { "city_id" });
            DropTable("dbo.Donators");
        }
    }
}
