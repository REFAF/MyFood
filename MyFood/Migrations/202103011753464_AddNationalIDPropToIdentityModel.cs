namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNationalIDPropToIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "national_id", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "national_id");
        }
    }
}
