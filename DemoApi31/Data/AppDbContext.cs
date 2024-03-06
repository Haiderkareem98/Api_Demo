using DemoApi31.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApi31.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        DbSet<Employee> Employees { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Certificate> Certificates { get; set; }
    }
}
