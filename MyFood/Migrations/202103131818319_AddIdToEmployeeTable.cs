namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdToEmployeeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "Id" });
            DropColumn("dbo.Employees", "Id");
        }
    }
}
