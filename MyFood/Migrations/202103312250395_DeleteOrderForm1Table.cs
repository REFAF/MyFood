namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteOrderForm1Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderForm1", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderForm1", "BuffetType_buffet_type_id", "dbo.BuffetTypes");
            DropIndex("dbo.OrderForm1", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.OrderForm1", new[] { "BuffetType_buffet_type_id" });
            DropTable("dbo.OrderForm1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderForm1",
                c => new
                    {
                        order_id = c.Int(nullable: false, identity: true),
                        day = c.String(maxLength: 50),
                        date = c.DateTime(storeType: "date"),
                        occasion_time = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                        persons_num = c.Byte(),
                        location = c.String(),
                        buffet_type_id = c.Byte(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        BuffetType_buffet_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.order_id);
            
            CreateIndex("dbo.OrderForm1", "BuffetType_buffet_type_id");
            CreateIndex("dbo.OrderForm1", "ApplicationUser_Id");
            AddForeignKey("dbo.OrderForm1", "BuffetType_buffet_type_id", "dbo.BuffetTypes", "buffet_type_id");
            AddForeignKey("dbo.OrderForm1", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
