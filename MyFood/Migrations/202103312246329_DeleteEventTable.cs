namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteEventTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Events");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        event_id = c.Long(nullable: false, identity: true),
                        event_date = c.DateTime(storeType: "date"),
                        event_time = c.Time(precision: 7),
                        reg_date = c.DateTime(),
                        orgType_id = c.Byte(),
                        org_name = c.String(maxLength: 50),
                        buffet_type_id = c.Byte(),
                        persons_num = c.Int(),
                        plate_num = c.Int(),
                        regdate = c.DateTime(),
                    })
                .PrimaryKey(t => t.event_id);
            
        }
    }
}
