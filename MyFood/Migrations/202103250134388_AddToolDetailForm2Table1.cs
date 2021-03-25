namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolDetailForm2Table1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToolDetailForm2",
                c => new
                    {
                        tool_detail_id = c.Long(nullable: false, identity: true),
                        tool_id = c.Int(),
                        tool_unit = c.String(),
                        quantity = c.Int(),
                        returned_tools = c.Int(),
                        note = c.String(),
                        f2_id = c.Long(),
                    })
                .PrimaryKey(t => t.tool_detail_id)
                .ForeignKey("dbo.CarToolForm2", t => t.f2_id)
                .ForeignKey("dbo.Tools", t => t.tool_id)
                .Index(t => t.tool_id)
                .Index(t => t.f2_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToolDetailForm2", "tool_id", "dbo.Tools");
            DropForeignKey("dbo.ToolDetailForm2", "f2_id", "dbo.CarToolForm2");
            DropIndex("dbo.ToolDetailForm2", new[] { "f2_id" });
            DropIndex("dbo.ToolDetailForm2", new[] { "tool_id" });
            DropTable("dbo.ToolDetailForm2");
        }
    }
}
