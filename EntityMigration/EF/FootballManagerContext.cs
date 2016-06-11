using System.Data.Entity;
using EntityMigration.Migrations;

namespace EntityMigration.EF
{
    public class FootballManagerContext : DbContext
    {
        public DbSet<FootballClub> FootballClub { get; set; }

        public FootballManagerContext() : base("name=FootballDb")
        {

        }

        static FootballManagerContext()
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}