using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SAOnlineMarket.Data;
using SAOnlineMarket.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SAOnlineMarketContextConnection") ?? throw new InvalidOperationException("Connection string 'SAOnlineMarketContextConnection' not found.");

builder.Services.AddDbContext<SAOnlineMarketContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SAOnlineMarketUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SAOnlineMarketContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
