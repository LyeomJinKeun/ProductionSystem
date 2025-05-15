using Microsoft.EntityFrameworkCore;
using ProductionSystem.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// DB 汲沥
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC + 技记
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSession(); // 技记 劝己拳

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();