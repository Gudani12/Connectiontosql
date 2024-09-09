using ConnectionToSQL.Models;
using database.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectionToSQL.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {


        }
        public DbSet<Course> Course { get; set; }

    }
}
