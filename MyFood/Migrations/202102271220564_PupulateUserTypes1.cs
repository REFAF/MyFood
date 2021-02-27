namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateUserTypes1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes (userType_name) VALUES('Organization')");
            Sql("INSERT INTO UserTypes (userType_name) VALUES('Individual')");
            Sql("INSERT INTO UserTypes (userType_name) VALUES('Beneficiary')");
        }
        
        public override void Down()
        {
        }
    }
}
