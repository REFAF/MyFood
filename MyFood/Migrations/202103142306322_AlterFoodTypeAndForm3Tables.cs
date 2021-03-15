namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFoodTypeAndForm3Tables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodReceiptForm3", "food_type_id", c => c.Byte());
            AddColumn("dbo.FoodTypes", "rice", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "chicken", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "meat", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "dates", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "fruit", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "gursan", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "pasta", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "buffet", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "water", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "soup", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "pies", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "bread", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "dessert", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "groats", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "vegetables", c => c.Boolean());
            AddColumn("dbo.FoodTypes", "juices", c => c.Boolean());
            CreateIndex("dbo.FoodReceiptForm3", "food_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes", "food_type_id");
            DropColumn("dbo.FoodTypes", "food_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodTypes", "food_name", c => c.String(maxLength: 50));
            DropForeignKey("dbo.FoodReceiptForm3", "food_type_id", "dbo.FoodTypes");
            DropIndex("dbo.FoodReceiptForm3", new[] { "food_type_id" });
            DropColumn("dbo.FoodTypes", "juices");
            DropColumn("dbo.FoodTypes", "vegetables");
            DropColumn("dbo.FoodTypes", "groats");
            DropColumn("dbo.FoodTypes", "dessert");
            DropColumn("dbo.FoodTypes", "bread");
            DropColumn("dbo.FoodTypes", "pies");
            DropColumn("dbo.FoodTypes", "soup");
            DropColumn("dbo.FoodTypes", "water");
            DropColumn("dbo.FoodTypes", "buffet");
            DropColumn("dbo.FoodTypes", "pasta");
            DropColumn("dbo.FoodTypes", "gursan");
            DropColumn("dbo.FoodTypes", "fruit");
            DropColumn("dbo.FoodTypes", "dates");
            DropColumn("dbo.FoodTypes", "meat");
            DropColumn("dbo.FoodTypes", "chicken");
            DropColumn("dbo.FoodTypes", "rice");
            DropColumn("dbo.FoodReceiptForm3", "food_type_id");
        }
    }
}
