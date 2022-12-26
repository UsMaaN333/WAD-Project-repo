using Microsoft.EntityFrameworkCore;
using WAD_SRMS_Project.models;

namespace WAD_SRMS_Project.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<MyyDataModel> DataModels { get; set; }
    }
}
