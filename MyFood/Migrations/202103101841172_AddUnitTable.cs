namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUnitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        unit_id = c.Byte(nullable: false),
                        unit_name = c.String(nullable: false, maxLength: 50),
                        category_id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.unit_id)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .Index(t => t.category_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "category_id", "dbo.Categories");
            DropIndex("dbo.Units", new[] { "category_id" });
            DropTable("dbo.Units");
        }
    }
}
