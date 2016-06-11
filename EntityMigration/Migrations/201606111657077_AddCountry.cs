namespace EntityMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootballClubs", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FootballClubs", "Country");
        }
    }
}
