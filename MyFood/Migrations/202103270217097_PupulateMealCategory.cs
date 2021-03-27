namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateMealCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MealCategories ( mealCategory_id, mealCategory_name) VALUES(1,N'‰’› ‰›—')");
            Sql("INSERT INTO MealCategories ( mealCategory_id, mealCategory_name) VALUES(2,N'‰›—')");
            Sql("INSERT INTO MealCategories ( mealCategory_id, mealCategory_name) VALUES(3,N' ‰›— Ê‰’›')");
            Sql("INSERT INTO MealCategories ( mealCategory_id, mealCategory_name) VALUES(4,N'‰›—Ì‰')");
        }
        
        public override void Down()
        {
        }
    }
}
