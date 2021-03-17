namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "BuffetType_buffet_type_id", "dbo.BuffetTypes");
            DropIndex("dbo.Orders", new[] { "BuffetType_buffet_type_id" });
            DropColumn("dbo.Orders", "buffet_type_id");
            DropColumn("dbo.Orders", "BuffetType_buffet_type_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "BuffetType_buffet_type_id", c => c.Int());
            AddColumn("dbo.Orders", "buffet_type_id", c => c.Byte());
            CreateIndex("dbo.Orders", "BuffetType_buffet_type_id");
            AddForeignKey("dbo.Orders", "BuffetType_buffet_type_id", "dbo.BuffetTypes", "buffet_type_id");
        }
    }
}
