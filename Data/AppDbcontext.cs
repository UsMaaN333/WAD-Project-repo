using Microsoft.EntityFrameworkCore;
using WAD_SRMS_Project.models;
namespace WAD_SRMS_Project.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<login> login { get; set; }
    }
}
