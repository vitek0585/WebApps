using EntityMigration.EF;

namespace EntityMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityMigration.EF.FootballManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EntityMigration.EF.FootballManagerContext context)
        {
            context.FootballClub.Add(new FootballClub()
            {
                Name = "Dynamo",
                Country = "Ukraine"
            });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}
