using Microsoft.EntityFrameworkCore;
using VisionFlowAPI.Models;

namespace VisionFlowAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoAnalysis> VideoAnalyses { get; set; }
    }
}