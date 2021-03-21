namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFoodTypeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodTypes", "rice", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "chicken", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "meat", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "dates", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "fruit", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "gursan", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "pasta", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "buffet", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "water", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "soup", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "pies", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "bread", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "dessert", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "groats", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "vegetables", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodTypes", "juices", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodTypes", "juices", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "vegetables", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "groats", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "dessert", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "bread", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "pies", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "soup", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "water", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "buffet", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "pasta", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "gursan", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "fruit", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "dates", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "meat", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "chicken", c => c.Boolean());
            AlterColumn("dbo.FoodTypes", "rice", c => c.Boolean());
        }
    }
}
