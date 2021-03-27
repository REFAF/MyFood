namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupulateTeamNumber : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(1,N'«·›—Ìﬁ «·«Ê·')");
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(2,N'«·›—Ìﬁ «·À«‰Ì')");
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(3,N'«·›—Ìﬁ «·À«·À')");
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(4,N'«·›—Ìﬁ «·—«»⁄')");
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(5,N'«·›—Ìﬁ «·Œ«„”')");
            Sql("INSERT INTO TeamNumbers ( Team_id, Team_name) VALUES(6,N'«·›—Ìﬁ «·”«œ”')");



        }

        public override void Down()
        {
        }
    }
}
