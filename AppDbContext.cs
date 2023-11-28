using GenericCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericCrud
{
    public class AppDbContext:DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<SystemInfo> Systems { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }




    }
}
