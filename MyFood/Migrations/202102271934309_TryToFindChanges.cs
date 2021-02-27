namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryToFindChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Beneficiaries", "name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Beneficiaries", "mobile", c => c.Int(nullable: false));
            AlterColumn("dbo.Beneficiaries", "address", c => c.String(nullable: false));
            AlterColumn("dbo.Beneficiaries", "family_number", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Beneficiaries", "family_number", c => c.Byte());
            AlterColumn("dbo.Beneficiaries", "address", c => c.String());
            AlterColumn("dbo.Beneficiaries", "mobile", c => c.Int());
            AlterColumn("dbo.Beneficiaries", "name", c => c.String(maxLength: 50));
        }
    }
}
