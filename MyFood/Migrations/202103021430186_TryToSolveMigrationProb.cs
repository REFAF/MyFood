namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryToSolveMigrationProb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "name", c => c.String());
            DropColumn("dbo.Beneficiaries", "name");
            DropColumn("dbo.Beneficiaries", "mobile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "mobile", c => c.Int(nullable: false));
            AddColumn("dbo.Beneficiaries", "name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.AspNetUsers", "name");
        }
    }
}
