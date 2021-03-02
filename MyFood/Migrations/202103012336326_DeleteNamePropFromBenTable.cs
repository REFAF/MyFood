namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteNamePropFromBenTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beneficiaries", "mobile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "mobile", c => c.Int(nullable: false));
        }
    }
}
