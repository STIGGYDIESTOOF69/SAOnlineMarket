using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAOnlineMarket.Areas.Identity.Data;
using SAOnlineMarket.Models;
using System.Reflection.Emit;

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

        builder.Entity<Product>().HasData(
        new Product { ProductId = 1, ProductName = "Biden", ProductDescription = "Can confirm he is one of the people of all time", ProductPrice = 200.00m , ProductImage = "https://media.newyorker.com/photos/630e85c820c2208e4152741d/master/pass/Cassidy-Biden-Month.jpg" }
        );

        builder.Entity<Product>().HasData(
        new Product { ProductId = 2, ProductName = "Cat", ProductDescription = "A very large and fluffy fellow", ProductPrice = 5.00m, ProductImage = "https://i.redd.it/3z3f8y6u1fn81.jpg" }
        );

        builder.Entity<Product>().HasData(
        new Product { ProductId = 3, ProductName = "Dog", ProductDescription = "Salivation", ProductPrice = 5.10m, ProductImage = "https://www.dogly.co.uk/wp-content/uploads/dog-with-a-huge-tongue.jpg" }
        );

        builder.Entity<Product>().HasData(
        new Product { ProductId = 4, ProductName = "Trump", ProductDescription = "Boosts user evasion skill by 5%", ProductPrice = 210.00m, ProductImage = "https://media-cldnry.s-nbcnews.com/image/upload/t_focal-440x220,f_auto,q_auto:best/rockcms/2024-08/240826-donald-trump-pro-choice-republicans-wm-146p-6025d1.jpg" }
        );

        builder.Entity<Product>().HasData(
        new Product { ProductId = 5, ProductName = "Nicolas Cage", ProductDescription = "bad to the bone.mp4", ProductPrice = 1000.00m, ProductImage = "https://i.pinimg.com/736x/0c/2f/50/0c2f50dd058a1409a390ae68de5dabdd.jpg" }
        );

        builder.Entity<Product>().HasData(
        new Product { ProductId = 6, ProductName = "Obama", ProductDescription = "His face is very comforting :3", ProductPrice = 700.00m, ProductImage = "https://media.newyorker.com/photos/590971f6c14b3c606c108102/master/pass/Crouch-Understanding-Obama-Basketball.jpg" }
        );

        
    }

public DbSet<SAOnlineMarket.Models.Product> Product { get; set; } = default!;

public DbSet<SAOnlineMarket.Models.Order> Order { get; set; } = default!;
}


