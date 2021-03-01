namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSomePropFromOrgTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Organizations", "org_name");
            DropColumn("dbo.Organizations", "phone_num");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "phone_num", c => c.Int());
            AddColumn("dbo.Organizations", "org_name", c => c.String(maxLength: 50));
        }
    }
}
