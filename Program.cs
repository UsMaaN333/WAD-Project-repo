
using Microsoft.EntityFrameworkCore;
using WAD_SRMS_Project.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString= builder.Configuration.GetConnectionString("dbconnection");
Console.WriteLine(connectionString);
builder.Services.AddDbContext<AppDbcontext>(options => options.UseSqlServer(connectionString));
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}/{id?}");
app.Run();
        