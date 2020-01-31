using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Models.School> School { get; set; }

        public DbSet<Models.Student> Students { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base (options)
        {
            
        }
        
    }
}