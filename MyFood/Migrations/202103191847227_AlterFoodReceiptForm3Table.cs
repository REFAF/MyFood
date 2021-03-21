namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFoodReceiptForm3Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodReceiptForm3", "healthy", c => c.Boolean(nullable: false));
            AddColumn("dbo.FoodReceiptForm3", "not_healthy", c => c.Boolean(nullable: false));
            DropColumn("dbo.FoodReceiptForm3", "staff_health");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodReceiptForm3", "staff_health", c => c.Boolean());
            DropColumn("dbo.FoodReceiptForm3", "not_healthy");
            DropColumn("dbo.FoodReceiptForm3", "healthy");
        }
    }
}
