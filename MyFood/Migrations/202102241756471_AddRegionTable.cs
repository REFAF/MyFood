namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        region_id = c.Int(nullable: false, identity: true),
                        region_name = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.region_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Regions");
        }
    }
}
