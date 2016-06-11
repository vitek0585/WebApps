namespace EntityMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootballClubs", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FootballClubs", "City");
        }
    }
}
