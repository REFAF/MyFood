namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNamePropFromBenTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beneficiaries", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
