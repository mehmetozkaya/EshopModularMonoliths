namespace Shared.Data.Seed;
public interface IDataSeeder<TContext> where TContext : DbContext
{
    Task SeedAllAsync(TContext context);
}
