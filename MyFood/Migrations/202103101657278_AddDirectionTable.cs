namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        direction_id = c.Byte(nullable: false, identity: true),
                        direction_name = c.String(nullable: false, maxLength: 50),
                        direction_symbol = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.direction_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Directions");
        }
    }
}
