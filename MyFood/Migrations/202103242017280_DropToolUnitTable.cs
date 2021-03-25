namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropToolUnitTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ToolUnits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ToolUnits",
                c => new
                    {
                        unit_id = c.Int(nullable: false, identity: true),
                        unit_name = c.String(),
                    })
                .PrimaryKey(t => t.unit_id);
            
        }
    }
}
