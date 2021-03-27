namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderIdToForm4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Form4A", "order_id", c => c.Long());
            CreateIndex("dbo.Form4A", "order_id");
            AddForeignKey("dbo.Form4A", "order_id", "dbo.Orders", "order_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Form4A", "order_id", "dbo.Orders");
            DropIndex("dbo.Form4A", new[] { "order_id" });
            DropColumn("dbo.Form4A", "order_id");
        }
    }
}
