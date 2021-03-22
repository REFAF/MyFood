namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3Table : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.FoodReceiptForm3", name: "safetyTool_id", newName: "safety_id_emp1");
            RenameIndex(table: "dbo.FoodReceiptForm3", name: "IX_safetyTool_id", newName: "IX_safety_id_emp1");
            AddColumn("dbo.FoodReceiptForm3", "safety_id_emp2", c => c.Int());
            AddColumn("dbo.FoodReceiptForm3", "safety_id_emp3", c => c.Int());
            CreateIndex("dbo.FoodReceiptForm3", "safety_id_emp2");
            CreateIndex("dbo.FoodReceiptForm3", "safety_id_emp3");
            AddForeignKey("dbo.FoodReceiptForm3", "safety_id_emp2", "dbo.SafetyTools", "safetyTool_id");
            AddForeignKey("dbo.FoodReceiptForm3", "safety_id_emp3", "dbo.SafetyTools", "safetyTool_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "safety_id_emp3", "dbo.SafetyTools");
            DropForeignKey("dbo.FoodReceiptForm3", "safety_id_emp2", "dbo.SafetyTools");
            DropIndex("dbo.FoodReceiptForm3", new[] { "safety_id_emp3" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "safety_id_emp2" });
            DropColumn("dbo.FoodReceiptForm3", "safety_id_emp3");
            DropColumn("dbo.FoodReceiptForm3", "safety_id_emp2");
            RenameIndex(table: "dbo.FoodReceiptForm3", name: "IX_safety_id_emp1", newName: "IX_safetyTool_id");
            RenameColumn(table: "dbo.FoodReceiptForm3", name: "safety_id_emp1", newName: "safetyTool_id");
        }
    }
}
