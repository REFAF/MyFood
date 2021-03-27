namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectionToUnit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "direction_id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Units", "direction_id");
            AddForeignKey("dbo.Units", "direction_id", "dbo.Directions", "direction_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "direction_id", "dbo.Directions");
            DropIndex("dbo.Units", new[] { "direction_id" });
            DropColumn("dbo.Units", "direction_id");
        }
    }
}
