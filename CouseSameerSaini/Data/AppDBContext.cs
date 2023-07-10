using CouseSameerSaini.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CouseSameerSaini.Data;

public class AppDBContext: DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Tag> Tags { get; set; }
}