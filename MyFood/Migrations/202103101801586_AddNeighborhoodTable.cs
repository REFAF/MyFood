namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNeighborhoodTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Neighborhoods",
                c => new
                    {
                        Neighborhood_id = c.Byte(nullable: false, identity: true),
                        Neighborhood_name = c.String(nullable: false, maxLength: 60),
                        direction_id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Neighborhood_id)
                .ForeignKey("dbo.Directions", t => t.direction_id, cascadeDelete: true)
                .Index(t => t.direction_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Neighborhoods", "direction_id", "dbo.Directions");
            DropIndex("dbo.Neighborhoods", new[] { "direction_id" });
            DropTable("dbo.Neighborhoods");
        }
    }
}
