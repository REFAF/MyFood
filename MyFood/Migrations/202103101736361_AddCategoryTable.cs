namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        category_id = c.Byte(nullable: false),
                        category_name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.category_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
