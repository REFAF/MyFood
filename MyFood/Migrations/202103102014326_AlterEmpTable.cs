namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterEmpTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "Emp_id", "dbo.Employees");
            DropForeignKey("dbo.SafetyTools", "Emp_id", "dbo.Employees");
            DropIndex("dbo.FoodReceiptForm3", new[] { "Emp_id" });
            DropIndex("dbo.SafetyTools", new[] { "Emp_id" });
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Employees", "national_id", c => c.Long(nullable: false));
            AddColumn("dbo.Employees", "Id", c => c.String(maxLength: 128));
            AddColumn("dbo.FoodReceiptForm3", "Employee_national_id", c => c.Long());
            AddColumn("dbo.SafetyTools", "Employee_national_id", c => c.Long());
            AddPrimaryKey("dbo.Employees", "national_id");
            CreateIndex("dbo.Employees", "Id");
            CreateIndex("dbo.FoodReceiptForm3", "Employee_national_id");
            CreateIndex("dbo.SafetyTools", "Employee_national_id");
            AddForeignKey("dbo.Employees", "Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.FoodReceiptForm3", "Employee_national_id", "dbo.Employees", "national_id");
            AddForeignKey("dbo.SafetyTools", "Employee_national_id", "dbo.Employees", "national_id");
            DropColumn("dbo.Employees", "Emp_id");
            DropColumn("dbo.Employees", "Emp_name");
            DropColumn("dbo.Employees", "mobile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "mobile", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Emp_name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Employees", "Emp_id", c => c.Long(nullable: false));
            DropForeignKey("dbo.SafetyTools", "Employee_national_id", "dbo.Employees");
            DropForeignKey("dbo.FoodReceiptForm3", "Employee_national_id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.SafetyTools", new[] { "Employee_national_id" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "Employee_national_id" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropPrimaryKey("dbo.Employees");
            DropColumn("dbo.SafetyTools", "Employee_national_id");
            DropColumn("dbo.FoodReceiptForm3", "Employee_national_id");
            DropColumn("dbo.Employees", "Id");
            DropColumn("dbo.Employees", "national_id");
            AddPrimaryKey("dbo.Employees", "Emp_id");
            CreateIndex("dbo.SafetyTools", "Emp_id");
            CreateIndex("dbo.FoodReceiptForm3", "Emp_id");
            AddForeignKey("dbo.SafetyTools", "Emp_id", "dbo.Employees", "Emp_id");
            AddForeignKey("dbo.FoodReceiptForm3", "Emp_id", "dbo.Employees", "Emp_id", cascadeDelete: true);
        }
    }
}
