namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3PK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3");
            DropIndex("dbo.SafetyTools", new[] { "f3_id" });
            DropPrimaryKey("dbo.FoodReceiptForm3");
            AlterColumn("dbo.FoodReceiptForm3", "f3_id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.SafetyTools", "f3_id", c => c.Long());
            AddPrimaryKey("dbo.FoodReceiptForm3", "f3_id");
            CreateIndex("dbo.SafetyTools", "f3_id");
            AddForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3", "f3_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3");
            DropIndex("dbo.SafetyTools", new[] { "f3_id" });
            DropPrimaryKey("dbo.FoodReceiptForm3");
            AlterColumn("dbo.SafetyTools", "f3_id", c => c.Int());
            AlterColumn("dbo.FoodReceiptForm3", "f3_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FoodReceiptForm3", "f3_id");
            CreateIndex("dbo.SafetyTools", "f3_id");
            AddForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3", "f3_id");
        }
    }
}
