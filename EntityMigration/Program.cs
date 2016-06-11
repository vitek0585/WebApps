using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityMigration.EF;
using EntityMigration.Migrations;

namespace EntityMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FootballManagerContext, Configuration>());

            var fm = new FootballManagerContext();
            var count = fm.FootballClub.Count();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
