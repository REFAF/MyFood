namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPropSectorToNeighborhoodId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beneficiaries", "Neighborhood_id", c => c.Byte(nullable: false));
            DropColumn("dbo.Beneficiaries", "sector_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "sector_id", c => c.Byte());
            DropColumn("dbo.Beneficiaries", "Neighborhood_id");
        }
    }
}
