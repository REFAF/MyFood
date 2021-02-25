namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        user_id = c.Long(nullable: false),
                        user_name = c.String(nullable: false, maxLength: 50),
                        mobile = c.Int(nullable: false),
                        role_id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.user_id)
                .ForeignKey("dbo.Roles", t => t.role_id, cascadeDelete: true)
                .Index(t => t.role_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "role_id", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "role_id" });
            DropTable("dbo.Employees");
        }
    }
}
