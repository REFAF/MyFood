namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePackagingFoTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Organizations", "city_id");
            DropTable("dbo.PackagingFollowUps");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PackagingFollowUps",
                c => new
                    {
                        pack_followup_id = c.Int(nullable: false, identity: true),
                        user_id = c.Long(),
                        inputorder_id = c.Int(),
                        haire = c.Boolean(),
                        nails = c.Boolean(),
                        cloth = c.Boolean(),
                        cap = c.Boolean(),
                        mask = c.Boolean(),
                        gloves = c.Boolean(),
                        note = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.pack_followup_id);
            
            AddColumn("dbo.Organizations", "city_id", c => c.Byte());
        }
    }
}
