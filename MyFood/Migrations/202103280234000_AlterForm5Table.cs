namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm5Table : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form5", "weight", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form5", "weight", c => c.Short());
        }
    }
}
