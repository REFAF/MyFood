namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES(1,'Admin')");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES(2,'Supervisor')");
            Sql("INSERT INTO AspNetRoles (Id, Name) VALUES(3,'Team Leader')");
        }
        
        public override void Down()
        {
        }
    }
}
