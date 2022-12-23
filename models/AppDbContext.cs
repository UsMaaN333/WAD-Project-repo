using Microsoft.EntityFrameworkCore;

namespace WAD_SRMS_Project.models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<loginModel> loginModels { get; set; }
    }
}
