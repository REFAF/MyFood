namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3car : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FoodReceiptForm3", "car_num");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodReceiptForm3", "car_num", c => c.Int());
        }
    }
}
