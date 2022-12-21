using Microsoft.EntityFrameworkCore;
using WAD_SRMS_Project.models;
namespace WAD_SRMS_Project.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<loginModel>? login { get; set; }
    }
}
