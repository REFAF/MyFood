namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm3caradd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodReceiptForm3", "car_num", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FoodReceiptForm3", "car_num");
        }
    }
}
