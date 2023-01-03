using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models;

public class BethanysPieShopDbContext: DbContext
{
    public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Pie> Pies { get; set; }
}

// Entity Framework is not available on Rider or VS for Mac. 
// Solution: 
// 1. install in the Project(not Solution): `dotnet tool install --global dotnet-ef`
// 2. run in the Project not Solution:  `dotnet ef migrations add "initialSetup"`
// this will create Migrations folder with snapshot
// 3. run `dotnet ef database update` <= Error!