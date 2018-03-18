
namespace Spike.DataSource
{
    using System.Data.Entity;
    using Entities;
    using Entities.Configs;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=Database.DataContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new BookConfiguration());
        }

        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<BookEntity> Books { get; set; }
    }
}
