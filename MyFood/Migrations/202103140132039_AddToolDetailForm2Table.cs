namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolDetailForm2Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToolDetailForm2",
                c => new
                    {
                        tool_detail_id = c.Long(nullable: false, identity: true),
                        quantity = c.Int(),
                        returned_tools = c.Int(),
                        note = c.String(),
                        tool_id = c.Int(),
                        tool_unit = c.String(),
                    })
                .PrimaryKey(t => t.tool_detail_id)
                .ForeignKey("dbo.Tools", t => t.tool_id)
                .Index(t => t.tool_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToolDetailForm2", "tool_id", "dbo.Tools");
            DropIndex("dbo.ToolDetailForm2", new[] { "tool_id" });
            DropTable("dbo.ToolDetailForm2");
        }
    }
}
