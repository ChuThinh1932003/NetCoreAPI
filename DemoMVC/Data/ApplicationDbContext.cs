using Microsoft.EntityFrameworkCore;
using DemoMVC.Models.Entities;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        
        public DbSet<Student> Student { get; set; }

        public DbSet<ChuDucThinh> ChuDucThinh { get; set; }
    }
}