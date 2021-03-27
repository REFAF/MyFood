namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMealCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealCategories",
                c => new
                    {
                        mealCategory_id = c.Byte(nullable: false),
                        mealCategory_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.mealCategory_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MealCategories");
        }
    }
}
