namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        role_id = c.Byte(nullable: false, identity: true),
                        role_name = c.String(nullable: false, maxLength: 50),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.role_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
        }
    }
}
