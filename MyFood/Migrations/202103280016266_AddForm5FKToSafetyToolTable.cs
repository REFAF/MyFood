namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForm5FKToSafetyToolTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SafetyTools", "form5_id", c => c.Long());
            CreateIndex("dbo.SafetyTools", "form5_id");
            AddForeignKey("dbo.SafetyTools", "form5_id", "dbo.Form5", "form5_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SafetyTools", "form5_id", "dbo.Form5");
            DropIndex("dbo.SafetyTools", new[] { "form5_id" });
            DropColumn("dbo.SafetyTools", "form5_id");
        }
    }
}
