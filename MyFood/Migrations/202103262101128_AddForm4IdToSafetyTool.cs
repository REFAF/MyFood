namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForm4IdToSafetyTool : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Form4A", "safetyTool_id", "dbo.SafetyTools");
            DropIndex("dbo.Form4A", new[] { "safetyTool_id" });
            AddColumn("dbo.SafetyTools", "form4A_id", c => c.Long());
            CreateIndex("dbo.SafetyTools", "form4A_id");
            AddForeignKey("dbo.SafetyTools", "form4A_id", "dbo.Form4A", "form4A_id");
            DropColumn("dbo.Form4A", "safetyTool_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Form4A", "safetyTool_id", c => c.Int());
            DropForeignKey("dbo.SafetyTools", "form4A_id", "dbo.Form4A");
            DropIndex("dbo.SafetyTools", new[] { "form4A_id" });
            DropColumn("dbo.SafetyTools", "form4A_id");
            CreateIndex("dbo.Form4A", "safetyTool_id");
            AddForeignKey("dbo.Form4A", "safetyTool_id", "dbo.SafetyTools", "safetyTool_id");
        }
    }
}
