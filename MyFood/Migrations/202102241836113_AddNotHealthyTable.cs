namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotHealthyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotHealthies",
                c => new
                    {
                        nothealthy_type_id = c.Byte(nullable: false, identity: true),
                        nothealthy_type_name = c.String(),
                    })
                .PrimaryKey(t => t.nothealthy_type_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NotHealthies");
        }
    }
}
