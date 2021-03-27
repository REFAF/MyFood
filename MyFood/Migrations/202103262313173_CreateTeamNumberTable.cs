namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTeamNumberTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamNumbers",
                c => new
                    {
                        Team_id = c.Byte(nullable: false),
                        Team_name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Team_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamNumbers");
        }
    }
}
