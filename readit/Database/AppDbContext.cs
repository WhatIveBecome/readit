using Microsoft.EntityFrameworkCore;
using readit.Models;

namespace readit.Database
{
    public class AppDbContext : DbContext
    {       
        public DbSet<ForumModel> Forums { get; set; }
        public DbSet<TopicModel> TopicModel { get; set; }
        public AppDbContext(DbContextOptions options) :base(options){}
    }
}
