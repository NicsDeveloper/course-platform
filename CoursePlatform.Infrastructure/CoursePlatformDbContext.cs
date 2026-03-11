using CoursePlatform.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoursePlatform.Infrastructure;

public class CoursePlatformDbContext(DbContextOptions<CoursePlatformDbContext> options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; }
}