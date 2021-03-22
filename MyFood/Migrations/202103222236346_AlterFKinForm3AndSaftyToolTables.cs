namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFKinForm3AndSaftyToolTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "safety_id_emp1", "dbo.SafetyTools");
            DropForeignKey("dbo.FoodReceiptForm3", "safety_id_emp2", "dbo.SafetyTools");
            DropForeignKey("dbo.FoodReceiptForm3", "safety_id_emp3", "dbo.SafetyTools");
            DropIndex("dbo.FoodReceiptForm3", new[] { "safety_id_emp1" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "safety_id_emp2" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "safety_id_emp3" });
            AddColumn("dbo.SafetyTools", "f3_id", c => c.Int());
            CreateIndex("dbo.SafetyTools", "f3_id");
            AddForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3", "f3_id");
            DropColumn("dbo.FoodReceiptForm3", "safety_id_emp1");
            DropColumn("dbo.FoodReceiptForm3", "safety_id_emp2");
            DropColumn("dbo.FoodReceiptForm3", "safety_id_emp3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodReceiptForm3", "safety_id_emp3", c => c.Int());
            AddColumn("dbo.FoodReceiptForm3", "safety_id_emp2", c => c.Int());
            AddColumn("dbo.FoodReceiptForm3", "safety_id_emp1", c => c.Int());
            DropForeignKey("dbo.SafetyTools", "f3_id", "dbo.FoodReceiptForm3");
            DropIndex("dbo.SafetyTools", new[] { "f3_id" });
            DropColumn("dbo.SafetyTools", "f3_id");
            CreateIndex("dbo.FoodReceiptForm3", "safety_id_emp3");
            CreateIndex("dbo.FoodReceiptForm3", "safety_id_emp2");
            CreateIndex("dbo.FoodReceiptForm3", "safety_id_emp1");
            AddForeignKey("dbo.FoodReceiptForm3", "safety_id_emp3", "dbo.SafetyTools", "safetyTool_id");
            AddForeignKey("dbo.FoodReceiptForm3", "safety_id_emp2", "dbo.SafetyTools", "safetyTool_id");
            AddForeignKey("dbo.FoodReceiptForm3", "safety_id_emp1", "dbo.SafetyTools", "safetyTool_id");
        }
    }
}
