namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDateTimeInForm5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form5", "date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form5", "date", c => c.DateTime(storeType: "date"));
        }
    }
}
