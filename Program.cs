
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WAD_SRMS_Project.Data;
using WAD_SRMS_Project.models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//var connectionString= builder.Configuration.GetConnectionString("dbconnection");
//Console.WriteLine(connectionString);
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(dbconnection)));
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=index}/{id?}");
app.Run();
        