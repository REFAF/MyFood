namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateUserType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes (userType_id,userType_name) VALUES(1,'Employee')");
            Sql("INSERT INTO UserTypes (userType_id,userType_name) VALUES(2,'Beneficiary')");
            Sql("INSERT INTO UserTypes (userType_id,userType_name) VALUES(3,'Organization')");
            Sql("INSERT INTO UserTypes (userType_id,userType_name) VALUES(4,'Indvidual')");
        }
        
        public override void Down()
        {
        }
    }
}
