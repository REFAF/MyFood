namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "user_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Orders", "emp_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Orders", "sup_id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "user_id");
            CreateIndex("dbo.Orders", "emp_id");
            CreateIndex("dbo.Orders", "sup_id");
            AddForeignKey("dbo.Orders", "emp_id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Orders", "sup_id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Orders", "user_id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "user_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "sup_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "emp_id", "dbo.AspNetUsers");
            DropIndex("dbo.Orders", new[] { "sup_id" });
            DropIndex("dbo.Orders", new[] { "emp_id" });
            DropIndex("dbo.Orders", new[] { "user_id" });
            DropColumn("dbo.Orders", "sup_id");
            DropColumn("dbo.Orders", "emp_id");
            DropColumn("dbo.Orders", "user_id");
        }
    }
}
