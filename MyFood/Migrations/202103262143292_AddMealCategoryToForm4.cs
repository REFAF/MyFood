namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMealCategoryToForm4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Form4A", "mealCategory_id", c => c.Byte());
            CreateIndex("dbo.Form4A", "mealCategory_id");
            AddForeignKey("dbo.Form4A", "mealCategory_id", "dbo.MealCategories", "mealCategory_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Form4A", "mealCategory_id", "dbo.MealCategories");
            DropIndex("dbo.Form4A", new[] { "mealCategory_id" });
            DropColumn("dbo.Form4A", "mealCategory_id");
        }
    }
}
