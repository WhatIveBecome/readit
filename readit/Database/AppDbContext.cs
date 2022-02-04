using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using readit.Models;

namespace readit.Database
{
    public class AppDbContext : IdentityDbContext
    {       
        public DbSet<ForumModel> Forums { get; set; }
        public DbSet<InfoModel> TopicModel { get; set; }
        public DbSet<TopicModel> Topics { get; set; }
        public DbSet<ReplyModel> Replies { get; set; }
        public AppDbContext(DbContextOptions options) :base(options){}
    }
}
