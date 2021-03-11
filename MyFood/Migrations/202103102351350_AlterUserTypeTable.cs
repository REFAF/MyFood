namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterUserTypeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes");
            DropPrimaryKey("dbo.UserTypes");
            AlterColumn("dbo.UserTypes", "userType_id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.UserTypes", "userType_id");
            AddForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes", "userType_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes");
            DropPrimaryKey("dbo.UserTypes");
            AlterColumn("dbo.UserTypes", "userType_id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserTypes", "userType_id");
            AddForeignKey("dbo.AspNetUsers", "userType_id", "dbo.UserTypes", "userType_id", cascadeDelete: true);
        }
    }
}
