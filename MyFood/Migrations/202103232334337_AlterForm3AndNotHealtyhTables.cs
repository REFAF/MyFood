namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3AndNotHealtyhTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies");
            DropIndex("dbo.FoodReceiptForm3", new[] { "nothealthy_type_id" });
            DropPrimaryKey("dbo.NotHealthies");
            AlterColumn("dbo.FoodReceiptForm3", "kilos_exit_time", c => c.Int());
            AlterColumn("dbo.FoodReceiptForm3", "kilos_arrival_time", c => c.Int());
            AlterColumn("dbo.FoodReceiptForm3", "kilos_return_time", c => c.Int());
            AlterColumn("dbo.FoodReceiptForm3", "nothealthy_type_id", c => c.Int());
            AlterColumn("dbo.NotHealthies", "nothealthy_type_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.NotHealthies", "nothealthy_type_id");
            CreateIndex("dbo.FoodReceiptForm3", "nothealthy_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies", "nothealthy_type_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies");
            DropIndex("dbo.FoodReceiptForm3", new[] { "nothealthy_type_id" });
            DropPrimaryKey("dbo.NotHealthies");
            AlterColumn("dbo.NotHealthies", "nothealthy_type_id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.FoodReceiptForm3", "nothealthy_type_id", c => c.Byte());
            AlterColumn("dbo.FoodReceiptForm3", "kilos_return_time", c => c.Byte());
            AlterColumn("dbo.FoodReceiptForm3", "kilos_arrival_time", c => c.Byte());
            AlterColumn("dbo.FoodReceiptForm3", "kilos_exit_time", c => c.Byte());
            AddPrimaryKey("dbo.NotHealthies", "nothealthy_type_id");
            CreateIndex("dbo.FoodReceiptForm3", "nothealthy_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies", "nothealthy_type_id");
        }
    }
}
