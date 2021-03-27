namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Team_id", c => c.Byte());
            CreateIndex("dbo.Employees", "Team_id");
            AddForeignKey("dbo.Employees", "Team_id", "dbo.TeamNumbers", "Team_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Team_id", "dbo.TeamNumbers");
            DropIndex("dbo.Employees", new[] { "Team_id" });
            DropColumn("dbo.Employees", "Team_id");
        }
    }
}
