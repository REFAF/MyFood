namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterBenIdToIdentityFromBenTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries");
            DropPrimaryKey("dbo.Beneficiaries");
            AlterColumn("dbo.Beneficiaries", "ben_id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Beneficiaries", "ben_id");
            AddForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries", "ben_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries");
            DropPrimaryKey("dbo.Beneficiaries");
            AlterColumn("dbo.Beneficiaries", "ben_id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Beneficiaries", "ben_id");
            AddForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries", "ben_id", cascadeDelete: true);
        }
    }
}
