using LupoonWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LupoonWeb.Data
{
    public class LupoonDbContext : DbContext
    {
        public LupoonDbContext(DbContextOptions options) : base(options) // Constructor for Db context
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }// can create table to the database
        public DbSet<Tag>Tags { get; set; }
    }
}
