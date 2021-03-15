namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarToolForm2Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarToolForm2",
                c => new
                    {
                        form2_id = c.Long(nullable: false, identity: true),
                        car_num = c.Int(),
                        delivery_date = c.DateTime(),
                        team_leader_id = c.String(maxLength: 128),
                        sup_id = c.String(maxLength: 128),
                        manager_id = c.String(maxLength: 128),
                        order_id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.form2_id)
                .ForeignKey("dbo.AspNetUsers", t => t.manager_id)
                .ForeignKey("dbo.Orders", t => t.order_id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.sup_id)
                .ForeignKey("dbo.AspNetUsers", t => t.team_leader_id)
                .Index(t => t.team_leader_id)
                .Index(t => t.sup_id)
                .Index(t => t.manager_id)
                .Index(t => t.order_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarToolForm2", "team_leader_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.CarToolForm2", "sup_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.CarToolForm2", "order_id", "dbo.Orders");
            DropForeignKey("dbo.CarToolForm2", "manager_id", "dbo.AspNetUsers");
            DropIndex("dbo.CarToolForm2", new[] { "order_id" });
            DropIndex("dbo.CarToolForm2", new[] { "manager_id" });
            DropIndex("dbo.CarToolForm2", new[] { "sup_id" });
            DropIndex("dbo.CarToolForm2", new[] { "team_leader_id" });
            DropTable("dbo.CarToolForm2");
        }
    }
}
