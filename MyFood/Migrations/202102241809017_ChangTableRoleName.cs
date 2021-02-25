namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangTableRoleName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Roles", newName: "EmpRoles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EmpRoles", newName: "Roles");
        }
    }
}
