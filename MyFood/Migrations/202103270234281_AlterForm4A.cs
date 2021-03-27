namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm4A : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form4A", "packing_date", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form4A", "packing_date", c => c.DateTime());
        }
    }
}
