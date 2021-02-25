namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDietTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diets",
                c => new
                    {
                        diet_id = c.Byte(nullable: false, identity: true),
                        diet_name = c.String(nullable: false),
                        desc = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.diet_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diets");
        }
    }
}
