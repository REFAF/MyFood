namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrgTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrgTypes",
                c => new
                    {
                        orgType_id = c.Byte(nullable: false, identity: true),
                        orgType_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.orgType_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrgTypes");
        }
    }
}
