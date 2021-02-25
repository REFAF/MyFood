namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuffetTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuffetTypes",
                c => new
                    {
                        buffet_type_id = c.Int(nullable: false, identity: true),
                        buffet_type_name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.buffet_type_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BuffetTypes");
        }
    }
}
