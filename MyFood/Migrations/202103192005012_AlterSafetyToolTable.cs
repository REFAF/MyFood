namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterSafetyToolTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SafetyTools", "clothing", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "hair", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "nails", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "clothing_claean", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "head_cover", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "face_mask", c => c.Boolean(nullable: false));
            AlterColumn("dbo.SafetyTools", "gloves", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SafetyTools", "gloves", c => c.Int());
            AlterColumn("dbo.SafetyTools", "face_mask", c => c.Boolean());
            AlterColumn("dbo.SafetyTools", "head_cover", c => c.Boolean());
            AlterColumn("dbo.SafetyTools", "clothing_claean", c => c.Boolean());
            AlterColumn("dbo.SafetyTools", "nails", c => c.Boolean());
            AlterColumn("dbo.SafetyTools", "hair", c => c.Boolean());
            AlterColumn("dbo.SafetyTools", "clothing", c => c.Boolean());
        }
    }
}
