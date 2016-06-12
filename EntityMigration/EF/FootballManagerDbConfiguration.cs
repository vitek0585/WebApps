using System.Data.Entity;
using EntityMigration.Migrations;

namespace EntityMigration.EF
{
    public class FootballManagerDbConfiguration : DbConfiguration
    {
        public FootballManagerDbConfiguration()
        {
            //SetDatabaseInitializer(new MigrateDatabaseToLatestVersion<FootballManagerContext, Configuration>());
        }
    }
}