using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using readit.Models;

namespace readit.Database
{
    public class AppDbContext : IdentityDbContext
    {       
        public DbSet<ForumModel> Forums { get; set; }
        public DbSet<TopicModel> TopicModel { get; set; }
        public DbSet<GeneralModel> General { get; set; }
        public AppDbContext(DbContextOptions options) :base(options){}
    }
}
