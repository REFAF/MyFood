namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNavPropertyOfUserToBenTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beneficiaries", "Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Beneficiaries", "Id");
            AddForeignKey("dbo.Beneficiaries", "Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beneficiaries", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Beneficiaries", new[] { "Id" });
            DropColumn("dbo.Beneficiaries", "Id");
        }
    }
}
