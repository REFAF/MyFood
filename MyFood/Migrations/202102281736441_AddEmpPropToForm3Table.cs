namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmpPropToForm3Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodReceiptForm3", "Emp_id", c => c.Long(nullable: false));
            CreateIndex("dbo.FoodReceiptForm3", "Emp_id");
            AddForeignKey("dbo.FoodReceiptForm3", "Emp_id", "dbo.Employees", "Emp_id", cascadeDelete: true);
            DropColumn("dbo.FoodReceiptForm3", "leader_id");
            DropColumn("dbo.FoodReceiptForm3", "supervisor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodReceiptForm3", "supervisor", c => c.Long());
            AddColumn("dbo.FoodReceiptForm3", "leader_id", c => c.Long());
            DropForeignKey("dbo.FoodReceiptForm3", "Emp_id", "dbo.Employees");
            DropIndex("dbo.FoodReceiptForm3", new[] { "Emp_id" });
            DropColumn("dbo.FoodReceiptForm3", "Emp_id");
        }
    }
}
