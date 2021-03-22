namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3ReportTable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodReceiptForm3", "exit_time", c => c.Time(precision: 7));
            AlterColumn("dbo.FoodReceiptForm3", "arrival_time", c => c.Time(precision: 7));
            AlterColumn("dbo.FoodReceiptForm3", "return_time", c => c.Time(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodReceiptForm3", "return_time", c => c.DateTime());
            AlterColumn("dbo.FoodReceiptForm3", "arrival_time", c => c.DateTime());
            AlterColumn("dbo.FoodReceiptForm3", "exit_time", c => c.String());
        }
    }
}
