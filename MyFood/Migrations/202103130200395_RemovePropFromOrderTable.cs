namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePropFromOrderTable : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "sup_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Orders", "emp_id", c => c.String(maxLength: 128));
            AddColumn("dbo.Orders", "user_id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "sup_id");
            CreateIndex("dbo.Orders", "emp_id");
            CreateIndex("dbo.Orders", "user_id");
            AddForeignKey("dbo.Orders", "user_id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Orders", "sup_id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Orders", "emp_id", "dbo.AspNetUsers", "Id");
        }
    }
}
