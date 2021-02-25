namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBeneficiaryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficiaries",
                c => new
                    {
                        ben_id = c.Long(nullable: false),
                        name = c.String(maxLength: 50),
                        mobile = c.Int(),
                        city_id = c.Byte(),
                        address = c.String(),
                        sector_id = c.Byte(),
                        location = c.String(),
                        guardian = c.String(maxLength: 50),
                        family_number = c.Byte(),
                    })
                .PrimaryKey(t => t.ben_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Beneficiaries");
        }
    }
}
