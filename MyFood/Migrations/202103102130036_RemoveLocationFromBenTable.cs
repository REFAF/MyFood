namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveLocationFromBenTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beneficiaries", "location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "location", c => c.String());
        }
    }
}
