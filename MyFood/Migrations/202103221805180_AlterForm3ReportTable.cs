namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3ReportTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodReceiptForm3", "exit_time", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodReceiptForm3", "exit_time", c => c.DateTime());
        }
    }
}
