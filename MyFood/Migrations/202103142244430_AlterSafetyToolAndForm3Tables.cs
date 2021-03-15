namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterSafetyToolAndForm3Tables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SafetyTools", "Employee_national_id", "dbo.Employees");
            DropIndex("dbo.SafetyTools", new[] { "Employee_national_id" });
            DropPrimaryKey("dbo.SafetyTools");
            AddColumn("dbo.FoodReceiptForm3", "safetyTool_id", c => c.Int());
            AddColumn("dbo.SafetyTools", "staff_name", c => c.String());
            AlterColumn("dbo.SafetyTools", "safetyTool_id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.SafetyTools", "clothing", c => c.Boolean());
            AddPrimaryKey("dbo.SafetyTools", "safetyTool_id");
            CreateIndex("dbo.FoodReceiptForm3", "safetyTool_id");
            AddForeignKey("dbo.FoodReceiptForm3", "safetyTool_id", "dbo.SafetyTools", "safetyTool_id");
            DropColumn("dbo.SafetyTools", "order_report_id");
            DropColumn("dbo.SafetyTools", "Emp_id");
            DropColumn("dbo.SafetyTools", "Employee_national_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SafetyTools", "Employee_national_id", c => c.Long());
            AddColumn("dbo.SafetyTools", "Emp_id", c => c.Long());
            AddColumn("dbo.SafetyTools", "order_report_id", c => c.Int());
            DropForeignKey("dbo.FoodReceiptForm3", "safetyTool_id", "dbo.SafetyTools");
            DropIndex("dbo.FoodReceiptForm3", new[] { "safetyTool_id" });
            DropPrimaryKey("dbo.SafetyTools");
            AlterColumn("dbo.SafetyTools", "clothing", c => c.String(maxLength: 10));
            AlterColumn("dbo.SafetyTools", "safetyTool_id", c => c.Int(nullable: false));
            DropColumn("dbo.SafetyTools", "staff_name");
            DropColumn("dbo.FoodReceiptForm3", "safetyTool_id");
            AddPrimaryKey("dbo.SafetyTools", "safetyTool_id");
            CreateIndex("dbo.SafetyTools", "Employee_national_id");
            AddForeignKey("dbo.SafetyTools", "Employee_national_id", "dbo.Employees", "national_id");
        }
    }
}
