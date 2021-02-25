namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSampleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Samples",
                c => new
                    {
                        sample_id = c.Int(nullable: false, identity: true),
                        product_id = c.Short(),
                        input_order_id = c.Int(),
                        sample_datetime = c.DateTime(),
                        wheight = c.Short(),
                    })
                .PrimaryKey(t => t.sample_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Samples");
        }
    }
}
