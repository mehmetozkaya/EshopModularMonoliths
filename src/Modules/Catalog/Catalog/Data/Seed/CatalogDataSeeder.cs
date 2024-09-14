namespace Catalog.Data.Seed;
public class CatalogDataSeeder
    : IDataSeeder<CatalogDbContext>
{
    public async Task SeedAllAsync(CatalogDbContext dbContext)
    {
        if (!await dbContext.Products.AnyAsync())
        {
            await dbContext.Products.AddRangeAsync(InitialData.Products);
            await dbContext.SaveChangesAsync();
        }
    }
}
