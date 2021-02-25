namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoodReceiptForm3Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodReceiptForm3",
                c => new
                    {
                        f3_id = c.Int(nullable: false),
                        car_num = c.Byte(),
                        staff_num = c.Byte(),
                        date = c.DateTime(storeType: "date"),
                        day = c.String(maxLength: 50),
                        staff_health_status_type_id = c.Byte(),
                        note = c.String(maxLength: 10),
                        leader_id = c.Long(),
                        supervisor = c.Long(),
                    })
                .PrimaryKey(t => t.f3_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodReceiptForm3");
        }
    }
}
