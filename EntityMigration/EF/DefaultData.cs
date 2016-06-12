using System.Data.Entity;

namespace EntityMigration.EF
{
    public class DefaultData:CreateDatabaseIfNotExists<FootballManagerContext>
    {
        protected override void Seed(FootballManagerContext context)
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