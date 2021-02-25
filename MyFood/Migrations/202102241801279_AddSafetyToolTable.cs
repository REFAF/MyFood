namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSafetyToolTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SafetyTools",
                c => new
                    {
                        safetyTool_id = c.Int(nullable: false),
                        order_report_id = c.Int(),
                        user_id = c.Long(),
                        clothing = c.String(maxLength: 10),
                        hair = c.Boolean(),
                        nails = c.Boolean(),
                        clothing_claean = c.Boolean(),
                        head_cover = c.Boolean(),
                        face_mask = c.Boolean(),
                        gloves = c.Int(),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.safetyTool_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SafetyTools");
        }
    }
}
