namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoodReceiptForm3Table2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodReceiptForm3", "edible", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FoodReceiptForm3", "inedible", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodReceiptForm3", "inedible", c => c.Boolean());
            AlterColumn("dbo.FoodReceiptForm3", "edible", c => c.Boolean());
        }
    }
}
