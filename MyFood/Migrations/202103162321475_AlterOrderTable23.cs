namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterOrderTable23 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Orders", new[] { "BuffetType_buffet_type_id" });
            DropColumn("dbo.Orders", "buffet_type_id");
            RenameColumn(table: "dbo.Orders", name: "BuffetType_buffet_type_id", newName: "buffet_type_id");
            AlterColumn("dbo.Orders", "buffet_type_id", c => c.Int());
            CreateIndex("dbo.Orders", "buffet_type_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Orders", new[] { "buffet_type_id" });
            AlterColumn("dbo.Orders", "buffet_type_id", c => c.Byte());
            RenameColumn(table: "dbo.Orders", name: "buffet_type_id", newName: "BuffetType_buffet_type_id");
            AddColumn("dbo.Orders", "buffet_type_id", c => c.Byte());
            CreateIndex("dbo.Orders", "BuffetType_buffet_type_id");
        }
    }
}
