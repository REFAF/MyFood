namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableEmployeeAndSafetyTool : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Employees", "Emp_id", c => c.Long(nullable: false));
            AddColumn("dbo.Employees", "Emp_name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.SafetyTools", "Emp_id", c => c.Long());
            AddPrimaryKey("dbo.Employees", "Emp_id");
            CreateIndex("dbo.SafetyTools", "Emp_id");
            AddForeignKey("dbo.SafetyTools", "Emp_id", "dbo.Employees", "Emp_id");
            DropColumn("dbo.Employees", "user_id");
            DropColumn("dbo.Employees", "user_name");
            DropColumn("dbo.SafetyTools", "user_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SafetyTools", "user_id", c => c.Long());
            AddColumn("dbo.Employees", "user_name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Employees", "user_id", c => c.Long(nullable: false));
            DropForeignKey("dbo.SafetyTools", "Emp_id", "dbo.Employees");
            DropIndex("dbo.SafetyTools", new[] { "Emp_id" });
            DropPrimaryKey("dbo.Employees");
            DropColumn("dbo.SafetyTools", "Emp_id");
            DropColumn("dbo.Employees", "Emp_name");
            DropColumn("dbo.Employees", "Emp_id");
            AddPrimaryKey("dbo.Employees", "user_id");
        }
    }
}
