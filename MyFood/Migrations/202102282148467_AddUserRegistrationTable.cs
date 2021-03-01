namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRegistrationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRegistrations",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        national_id = c.Long(),
                        mobile = c.String(),
                        email = c.String(),
                        email_confirmed = c.Boolean(),
                        password = c.String(nullable: false, maxLength: 100),
                        userType_id = c.Byte(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserTypes", t => t.userType_id)
                .Index(t => t.userType_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRegistrations", "userType_id", "dbo.UserTypes");
            DropIndex("dbo.UserRegistrations", new[] { "userType_id" });
            DropTable("dbo.UserRegistrations");
        }
    }
}
