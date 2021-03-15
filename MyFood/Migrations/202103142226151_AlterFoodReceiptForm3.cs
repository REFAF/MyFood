namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterFoodReceiptForm3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "Employee_national_id", "dbo.Employees");
            DropIndex("dbo.FoodReceiptForm3", new[] { "Employee_national_id" });
            DropPrimaryKey("dbo.FoodReceiptForm3");
            AddColumn("dbo.FoodReceiptForm3", "staff_health", c => c.Boolean());
            AddColumn("dbo.FoodReceiptForm3", "cart_num", c => c.Byte());
            AddColumn("dbo.FoodReceiptForm3", "pot_num", c => c.Byte());
            AddColumn("dbo.FoodReceiptForm3", "edible", c => c.Boolean());
            AddColumn("dbo.FoodReceiptForm3", "inedible", c => c.Boolean());
            AddColumn("dbo.FoodReceiptForm3", "exit_time", c => c.DateTime());
            AddColumn("dbo.FoodReceiptForm3", "arrival_time", c => c.DateTime());
            AddColumn("dbo.FoodReceiptForm3", "return_time", c => c.DateTime());
            AddColumn("dbo.FoodReceiptForm3", "kilos_exit_time", c => c.Byte());
            AddColumn("dbo.FoodReceiptForm3", "kilos_arrival_time", c => c.Byte());
            AddColumn("dbo.FoodReceiptForm3", "kilos_return_time", c => c.Byte());
            AddColumn("dbo.FoodReceiptForm3", "order_id", c => c.Long(nullable: false));
            AddColumn("dbo.FoodReceiptForm3", "team_leader_id", c => c.String(maxLength: 128));
            AddColumn("dbo.FoodReceiptForm3", "sup_id", c => c.String(maxLength: 128));
            AlterColumn("dbo.FoodReceiptForm3", "f3_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FoodReceiptForm3", "f3_id");
            CreateIndex("dbo.FoodReceiptForm3", "order_id");
            CreateIndex("dbo.FoodReceiptForm3", "team_leader_id");
            CreateIndex("dbo.FoodReceiptForm3", "sup_id");
            AddForeignKey("dbo.FoodReceiptForm3", "order_id", "dbo.Orders", "order_id", cascadeDelete: true);
            AddForeignKey("dbo.FoodReceiptForm3", "sup_id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.FoodReceiptForm3", "team_leader_id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.FoodReceiptForm3", "staff_health_status_type_id");
            DropColumn("dbo.FoodReceiptForm3", "Emp_id");
            DropColumn("dbo.FoodReceiptForm3", "Employee_national_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodReceiptForm3", "Employee_national_id", c => c.Long());
            AddColumn("dbo.FoodReceiptForm3", "Emp_id", c => c.Long(nullable: false));
            AddColumn("dbo.FoodReceiptForm3", "staff_health_status_type_id", c => c.Byte());
            DropForeignKey("dbo.FoodReceiptForm3", "team_leader_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FoodReceiptForm3", "sup_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FoodReceiptForm3", "order_id", "dbo.Orders");
            DropIndex("dbo.FoodReceiptForm3", new[] { "sup_id" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "team_leader_id" });
            DropIndex("dbo.FoodReceiptForm3", new[] { "order_id" });
            DropPrimaryKey("dbo.FoodReceiptForm3");
            AlterColumn("dbo.FoodReceiptForm3", "f3_id", c => c.Int(nullable: false));
            DropColumn("dbo.FoodReceiptForm3", "sup_id");
            DropColumn("dbo.FoodReceiptForm3", "team_leader_id");
            DropColumn("dbo.FoodReceiptForm3", "order_id");
            DropColumn("dbo.FoodReceiptForm3", "kilos_return_time");
            DropColumn("dbo.FoodReceiptForm3", "kilos_arrival_time");
            DropColumn("dbo.FoodReceiptForm3", "kilos_exit_time");
            DropColumn("dbo.FoodReceiptForm3", "return_time");
            DropColumn("dbo.FoodReceiptForm3", "arrival_time");
            DropColumn("dbo.FoodReceiptForm3", "exit_time");
            DropColumn("dbo.FoodReceiptForm3", "inedible");
            DropColumn("dbo.FoodReceiptForm3", "edible");
            DropColumn("dbo.FoodReceiptForm3", "pot_num");
            DropColumn("dbo.FoodReceiptForm3", "cart_num");
            DropColumn("dbo.FoodReceiptForm3", "staff_health");
            AddPrimaryKey("dbo.FoodReceiptForm3", "f3_id");
            CreateIndex("dbo.FoodReceiptForm3", "Employee_national_id");
            AddForeignKey("dbo.FoodReceiptForm3", "Employee_national_id", "dbo.Employees", "national_id");
        }
    }
}
