namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDirectionId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Neighborhoods", "direction_id", "dbo.Directions");
            DropPrimaryKey("dbo.Directions");
            AlterColumn("dbo.Directions", "direction_id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Directions", "direction_id");
            AddForeignKey("dbo.Neighborhoods", "direction_id", "dbo.Directions", "direction_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Neighborhoods", "direction_id", "dbo.Directions");
            DropPrimaryKey("dbo.Directions");
            AlterColumn("dbo.Directions", "direction_id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Directions", "direction_id");
            AddForeignKey("dbo.Neighborhoods", "direction_id", "dbo.Directions", "direction_id", cascadeDelete: true);
        }
    }
}
