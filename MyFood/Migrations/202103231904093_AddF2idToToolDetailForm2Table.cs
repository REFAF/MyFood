namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddF2idToToolDetailForm2Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToolDetailForm2", "f2_id", c => c.Long());
            CreateIndex("dbo.ToolDetailForm2", "f2_id");
            AddForeignKey("dbo.ToolDetailForm2", "f2_id", "dbo.CarToolForm2", "form2_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToolDetailForm2", "f2_id", "dbo.CarToolForm2");
            DropIndex("dbo.ToolDetailForm2", new[] { "f2_id" });
            DropColumn("dbo.ToolDetailForm2", "f2_id");
        }
    }
}
