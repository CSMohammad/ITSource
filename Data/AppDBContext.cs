using ITSource.Models;
using Microsoft.EntityFrameworkCore;

public class AppDBContext : DbContext{
    public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
    {
        
    }
    //to create tables in DB:
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Chapter> Chapters { get; set; }


}