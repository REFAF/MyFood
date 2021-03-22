namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodReceiptForm3", "car_num", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodReceiptForm3", "car_num", c => c.Byte());
        }
    }
}
