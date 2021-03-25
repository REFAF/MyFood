namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropToolDetailForm2Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToolDetailForm2", "f2_id", "dbo.CarToolForm2");
            DropForeignKey("dbo.ToolDetailForm2", "tool_id", "dbo.Tools");
            DropIndex("dbo.ToolDetailForm2", new[] { "tool_id" });
            DropIndex("dbo.ToolDetailForm2", new[] { "f2_id" });
            DropTable("dbo.ToolDetailForm2");
        }
        
        public override void Down()
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
                        f2_id = c.Long(),
                    })
                .PrimaryKey(t => t.tool_detail_id);
            
            CreateIndex("dbo.ToolDetailForm2", "f2_id");
            CreateIndex("dbo.ToolDetailForm2", "tool_id");
            AddForeignKey("dbo.ToolDetailForm2", "tool_id", "dbo.Tools", "tool_id");
            AddForeignKey("dbo.ToolDetailForm2", "f2_id", "dbo.CarToolForm2", "form2_id");
        }
    }
}
