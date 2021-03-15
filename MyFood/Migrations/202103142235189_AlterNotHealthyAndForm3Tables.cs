namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterNotHealthyAndForm3Tables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodReceiptForm3", "nothealthy_type_id", c => c.Byte());
            AddColumn("dbo.NotHealthies", "Employee1_name", c => c.String());
            AddColumn("dbo.NotHealthies", "Employee2_name", c => c.String());
            AddColumn("dbo.NotHealthies", "note", c => c.String());
            CreateIndex("dbo.FoodReceiptForm3", "nothealthy_type_id");
            AddForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies", "nothealthy_type_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodReceiptForm3", "nothealthy_type_id", "dbo.NotHealthies");
            DropIndex("dbo.FoodReceiptForm3", new[] { "nothealthy_type_id" });
            DropColumn("dbo.NotHealthies", "note");
            DropColumn("dbo.NotHealthies", "Employee2_name");
            DropColumn("dbo.NotHealthies", "Employee1_name");
            DropColumn("dbo.FoodReceiptForm3", "nothealthy_type_id");
        }
    }
}
