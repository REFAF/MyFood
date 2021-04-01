namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterWeightInForm4A : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form4A", "meal_weight", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form4A", "meal_weight", c => c.Int());
        }
    }
}
