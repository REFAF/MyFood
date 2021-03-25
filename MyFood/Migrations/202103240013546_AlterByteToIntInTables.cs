namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterByteToIntInTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes");
            DropIndex("dbo.FoodReceiptForm3", new[] { "food_type_id" });
            DropPrimaryKey("dbo.FoodTypes");
            AlterColumn("dbo.FoodReceiptForm3", "food_type_id", c => c.Int());
            AlterColumn("dbo.FoodTypes", "food_type_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FoodTypes", "food_type_id");
            CreateIndex("dbo.FoodReceiptForm3", "food_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes", "food_type_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes");
            DropIndex("dbo.FoodReceiptForm3", new[] { "food_type_id" });
            DropPrimaryKey("dbo.FoodTypes");
            AlterColumn("dbo.FoodTypes", "food_type_id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.FoodReceiptForm3", "food_type_id", c => c.Byte());
            AddPrimaryKey("dbo.FoodTypes", "food_type_id");
            CreateIndex("dbo.FoodReceiptForm3", "food_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes", "food_type_id");
        }
    }
}
