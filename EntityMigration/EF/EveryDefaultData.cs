using System.Data.Entity;

namespace EntityMigration.EF
{
    public class EveryDefaultData:NullDatabaseInitializer<FootballManagerContext>
    {
        public override void InitializeDatabase(FootballManagerContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}