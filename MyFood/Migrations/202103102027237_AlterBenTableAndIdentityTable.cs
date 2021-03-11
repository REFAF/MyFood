namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterBenTableAndIdentityTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries");
            DropIndex("dbo.FamilyDiets", new[] { "ben_id" });
            DropPrimaryKey("dbo.Beneficiaries");
            AddColumn("dbo.Beneficiaries", "national_id", c => c.Long(nullable: false));
            AddColumn("dbo.FamilyDiets", "Beneficiary_national_id", c => c.Long());
            AddPrimaryKey("dbo.Beneficiaries", "national_id");
            CreateIndex("dbo.FamilyDiets", "Beneficiary_national_id");
            AddForeignKey("dbo.FamilyDiets", "Beneficiary_national_id", "dbo.Beneficiaries", "national_id");
            DropColumn("dbo.Beneficiaries", "ben_id");
            DropColumn("dbo.AspNetUsers", "national_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "national_id", c => c.String());
            AddColumn("dbo.Beneficiaries", "ben_id", c => c.Long(nullable: false, identity: true));
            DropForeignKey("dbo.FamilyDiets", "Beneficiary_national_id", "dbo.Beneficiaries");
            DropIndex("dbo.FamilyDiets", new[] { "Beneficiary_national_id" });
            DropPrimaryKey("dbo.Beneficiaries");
            DropColumn("dbo.FamilyDiets", "Beneficiary_national_id");
            DropColumn("dbo.Beneficiaries", "national_id");
            AddPrimaryKey("dbo.Beneficiaries", "ben_id");
            CreateIndex("dbo.FamilyDiets", "ben_id");
            AddForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries", "ben_id", cascadeDelete: true);
        }
    }
}
