namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReportStatusToForm5Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Form5", "report_status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Form5", "report_status");
        }
    }
}
