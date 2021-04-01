namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteEmpRoleTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EmpRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmpRoles",
                c => new
                    {
                        role_id = c.Byte(nullable: false, identity: true),
                        role_name = c.String(nullable: false, maxLength: 50),
                        note = c.String(),
                    })
                .PrimaryKey(t => t.role_id);
            
        }
    }
}
