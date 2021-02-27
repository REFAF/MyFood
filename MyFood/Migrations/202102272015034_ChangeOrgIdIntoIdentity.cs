namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOrgIdIntoIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Organizations");
            AlterColumn("dbo.Organizations", "org_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Organizations", "org_id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Organizations");
            AlterColumn("dbo.Organizations", "org_id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Organizations", "org_id");
        }
    }
}
