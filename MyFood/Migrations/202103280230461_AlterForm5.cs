namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterForm5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Form5", "weight", c => c.Short());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Form5", "weight", c => c.Byte());
        }
    }
}
