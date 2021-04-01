namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterDateTimeInForm3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodReceiptForm3", "date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodReceiptForm3", "date", c => c.DateTime(storeType: "date"));
        }
    }
}
