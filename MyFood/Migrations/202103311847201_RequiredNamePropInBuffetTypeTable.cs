namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredNamePropInBuffetTypeTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BuffetTypes", "buffet_type_name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BuffetTypes", "buffet_type_name", c => c.String(maxLength: 30));
        }
    }
}
