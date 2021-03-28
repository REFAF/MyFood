namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForm5Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Form5",
                c => new
                    {
                        form5_id = c.Long(nullable: false, identity: true),
                        car_num = c.Int(),
                        staff_num = c.Byte(),
                        date = c.DateTime(storeType: "date"),
                        day = c.String(maxLength: 50),
                        healthy = c.Boolean(nullable: false),
                        not_healthy = c.Boolean(nullable: false),
                        meal_num = c.Byte(),
                        weight = c.Byte(),
                        families = c.String(),
                        individual = c.String(),
                        exit_time = c.Time(precision: 7),
                        arrival_time = c.Time(precision: 7),
                        return_time = c.Time(precision: 7),
                        kilos_exit_time = c.Int(),
                        kilos_arrival_time = c.Int(),
                        kilos_return_time = c.Int(),
                        note = c.String(maxLength: 10),
                        Neighborhood_id = c.Byte(),
                        nothealthy_type_id = c.Int(),
                        food_type_id = c.Int(),
                        team_leader_id = c.String(maxLength: 128),
                        sup_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.form5_id)
                .ForeignKey("dbo.FoodTypes", t => t.food_type_id)
                .ForeignKey("dbo.Neighborhoods", t => t.Neighborhood_id)
                .ForeignKey("dbo.NotHealthies", t => t.nothealthy_type_id)
                .ForeignKey("dbo.AspNetUsers", t => t.sup_id)
                .ForeignKey("dbo.AspNetUsers", t => t.team_leader_id)
                .Index(t => t.Neighborhood_id)
                .Index(t => t.nothealthy_type_id)
                .Index(t => t.food_type_id)
                .Index(t => t.team_leader_id)
                .Index(t => t.sup_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Form5", "team_leader_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Form5", "sup_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Form5", "nothealthy_type_id", "dbo.NotHealthies");
            DropForeignKey("dbo.Form5", "Neighborhood_id", "dbo.Neighborhoods");
            DropForeignKey("dbo.Form5", "food_type_id", "dbo.FoodTypes");
            DropIndex("dbo.Form5", new[] { "sup_id" });
            DropIndex("dbo.Form5", new[] { "team_leader_id" });
            DropIndex("dbo.Form5", new[] { "food_type_id" });
            DropIndex("dbo.Form5", new[] { "nothealthy_type_id" });
            DropIndex("dbo.Form5", new[] { "Neighborhood_id" });
            DropTable("dbo.Form5");
        }
    }
}
