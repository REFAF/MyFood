namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoodTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        food_type_id = c.Byte(nullable: false, identity: true),
                        food_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.food_type_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodTypes");
        }
    }
}
