using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAOnlineMarket.Areas.Identity.Data;

namespace SAOnlineMarket.Data;

public class SAOnlineMarketContext : IdentityDbContext<SAOnlineMarketUser>
{
    public SAOnlineMarketContext(DbContextOptions<SAOnlineMarketContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
