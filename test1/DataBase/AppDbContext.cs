using System.Data.Entity;
using test1.DataBase.Models;

namespace test1.DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MyConnection")
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Dep> Deps { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
