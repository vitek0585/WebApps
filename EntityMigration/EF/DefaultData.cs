using System.Data.Entity;

namespace EntityMigration.EF
{
    public class DefaultData:CreateDatabaseIfNotExists<FootballManagerContext>
    {
        protected override void Seed(FootballManagerContext context)
        {
            
        }
    }
}