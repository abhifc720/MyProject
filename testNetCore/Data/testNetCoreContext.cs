using Microsoft.EntityFrameworkCore;

namespace testNetCore.Models
{
    public class testNetCoreContext : DbContext
    {
        public testNetCoreContext (DbContextOptions<testNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<testNetCore.Models.Movie> Movie { get; set; }
    }
}
