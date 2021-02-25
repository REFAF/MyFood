namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFamilyDietTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilyDiets",
                c => new
                    {
                        family_diet_id = c.Int(nullable: false, identity: true),
                        ben_id = c.Long(nullable: false),
                        person_num = c.Byte(),
                        diet1_id = c.Byte(),
                        diet2_id = c.Byte(),
                        diet3_id = c.Byte(),
                        diet4_id = c.Byte(),
                        diet5_id = c.Byte(),
                        diet6_id = c.Byte(),
                        diet7_id = c.Byte(),
                        diet8_id = c.Byte(),
                        diet9_id = c.Byte(),
                        diet10_id = c.Byte(),
                        Diet_diet_id = c.Byte(),
                    })
                .PrimaryKey(t => t.family_diet_id)
                .ForeignKey("dbo.Beneficiaries", t => t.ben_id, cascadeDelete: true)
                .ForeignKey("dbo.Diets", t => t.Diet_diet_id)
                .Index(t => t.ben_id)
                .Index(t => t.Diet_diet_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FamilyDiets", "Diet_diet_id", "dbo.Diets");
            DropForeignKey("dbo.FamilyDiets", "ben_id", "dbo.Beneficiaries");
            DropIndex("dbo.FamilyDiets", new[] { "Diet_diet_id" });
            DropIndex("dbo.FamilyDiets", new[] { "ben_id" });
            DropTable("dbo.FamilyDiets");
        }
    }
}
