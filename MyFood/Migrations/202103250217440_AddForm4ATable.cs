namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForm4ATable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Form4A",
                c => new
                    {
                        form4A_id = c.Long(nullable: false, identity: true),
                        Emp1 = c.String(),
                        Emp2 = c.String(),
                        team_leader_id = c.String(maxLength: 128),
                        sup_id = c.String(maxLength: 128),
                        meal_num = c.Int(),
                        meal_weight = c.Int(),
                        sample_num = c.Byte(),
                        packing_date = c.DateTime(),
                        day = c.String(),
                        safetyTool_id = c.Int(),
                    })
                .PrimaryKey(t => t.form4A_id)
                .ForeignKey("dbo.SafetyTools", t => t.safetyTool_id)
                .ForeignKey("dbo.AspNetUsers", t => t.sup_id)
                .ForeignKey("dbo.AspNetUsers", t => t.team_leader_id)
                .Index(t => t.team_leader_id)
                .Index(t => t.sup_id)
                .Index(t => t.safetyTool_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Form4A", "team_leader_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Form4A", "sup_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Form4A", "safetyTool_id", "dbo.SafetyTools");
            DropIndex("dbo.Form4A", new[] { "safetyTool_id" });
            DropIndex("dbo.Form4A", new[] { "sup_id" });
            DropIndex("dbo.Form4A", new[] { "team_leader_id" });
            DropTable("dbo.Form4A");
        }
    }
}
