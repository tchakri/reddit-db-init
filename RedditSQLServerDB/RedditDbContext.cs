using Microsoft.EntityFrameworkCore;
using RedditSQLServerDB.Entities;

namespace RedditSQLServerDB
{
    public class RedditDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YY193508;Database=RedditDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<More> Mores { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
