namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNavPropToBenTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Beneficiaries", "Neighborhood_id");
            AddForeignKey("dbo.Beneficiaries", "Neighborhood_id", "dbo.Neighborhoods", "Neighborhood_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beneficiaries", "Neighborhood_id", "dbo.Neighborhoods");
            DropIndex("dbo.Beneficiaries", new[] { "Neighborhood_id" });
        }
    }
}
