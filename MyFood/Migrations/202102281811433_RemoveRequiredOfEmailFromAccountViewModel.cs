namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredOfEmailFromAccountViewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderForm1", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.OrderForm1", "ApplicationUser_Id");
            AddForeignKey("dbo.OrderForm1", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderForm1", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.OrderForm1", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.OrderForm1", "ApplicationUser_Id");
        }
    }
}
