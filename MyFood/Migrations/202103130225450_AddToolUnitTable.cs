namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolUnitTable : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.ToolUnits");
        }
    }
}
