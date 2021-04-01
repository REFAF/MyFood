namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredNamePropInOrgTypeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrgTypes", "orgType_name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrgTypes", "orgType_name", c => c.String(maxLength: 50));
        }
    }
}
