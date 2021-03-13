namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        tool_id = c.Int(nullable: false, identity: true),
                        tool_name = c.String(),
                    })
                .PrimaryKey(t => t.tool_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tools");
        }
    }
}
