namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        userType_id = c.Byte(nullable: false, identity: true),
                        userType_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.userType_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTypes");
        }
    }
}
