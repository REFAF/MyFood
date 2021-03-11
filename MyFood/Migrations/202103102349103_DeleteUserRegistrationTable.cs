namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUserRegistrationTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRegistrations", "userType_id", "dbo.UserTypes");
            DropIndex("dbo.UserRegistrations", new[] { "userType_id" });
            DropTable("dbo.UserRegistrations");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.UserRegistrations", "userType_id");
            AddForeignKey("dbo.UserRegistrations", "userType_id", "dbo.UserTypes", "userType_id");
        }
    }
}
