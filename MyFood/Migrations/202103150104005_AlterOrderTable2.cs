namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "category_id", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "category_id" });
            DropColumn("dbo.Orders", "category_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "category_id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Orders", "category_id");
            AddForeignKey("dbo.Orders", "category_id", "dbo.Categories", "category_id", cascadeDelete: true);
        }
    }
}
