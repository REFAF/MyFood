namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        order_id = c.Long(nullable: false, identity: true),
                        phone_number = c.String(),
                        event_date = c.DateTime(storeType: "date"),
                        event_time = c.Time(precision: 7),
                        reservation_date = c.DateTime(),
                        category_id = c.Byte(nullable: false),
                        unit_id = c.Byte(),
                        address = c.String(),
                        buffet_type_id = c.Byte(),
                        plate_num = c.Int(),
                        persons_num = c.Int(),
                        Id = c.String(maxLength: 128),
                        BuffetType_buffet_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.order_id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .ForeignKey("dbo.BuffetTypes", t => t.BuffetType_buffet_type_id)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.unit_id)
                .Index(t => t.category_id)
                .Index(t => t.unit_id)
                .Index(t => t.Id)
                .Index(t => t.BuffetType_buffet_type_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "unit_id", "dbo.Units");
            DropForeignKey("dbo.Orders", "category_id", "dbo.Categories");
            DropForeignKey("dbo.Orders", "BuffetType_buffet_type_id", "dbo.BuffetTypes");
            DropForeignKey("dbo.Orders", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "BuffetType_buffet_type_id" });
            DropIndex("dbo.Orders", new[] { "Id" });
            DropIndex("dbo.Orders", new[] { "unit_id" });
            DropIndex("dbo.Orders", new[] { "category_id" });
            DropTable("dbo.Orders");
        }
    }
}
