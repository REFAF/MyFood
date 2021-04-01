namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCityFK : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beneficiaries", "city_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiaries", "city_id", c => c.Byte());
        }
    }
}
