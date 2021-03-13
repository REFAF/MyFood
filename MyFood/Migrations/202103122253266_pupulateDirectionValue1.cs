namespace MyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pupulateDirectionValue1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Directions (direction_id,direction_name,direction_symbol) VALUES(1,N'‘„«·','N')");
            Sql("INSERT INTO Directions (direction_id,direction_name,direction_symbol) VALUES(2,N'Ã‰Ê»','S')");
            Sql("INSERT INTO Directions (direction_id,direction_name,direction_symbol) VALUES(3,N'‘—ﬁ','E')");
            Sql("INSERT INTO Directions (direction_id,direction_name,direction_symbol) VALUES(4,N'€—»','W')");
        }
        
        public override void Down()
        {
        }
    }
}
