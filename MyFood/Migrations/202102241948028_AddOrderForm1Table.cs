namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderForm1Table : DbMigration
    {
        public override void Up()
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
                        BuffetType_buffet_type_id = c.Int(),
                    })
                .PrimaryKey(t => t.order_id)
                .ForeignKey("dbo.BuffetTypes", t => t.BuffetType_buffet_type_id)
                .Index(t => t.BuffetType_buffet_type_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderForm1", "BuffetType_buffet_type_id", "dbo.BuffetTypes");
            DropIndex("dbo.OrderForm1", new[] { "BuffetType_buffet_type_id" });
            DropTable("dbo.OrderForm1");
        }
    }
}
