using GitHubAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubAPI.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options): base(options)
        {
        }
        public DbSet<GitRepositories> GitRepositories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
    }
}
