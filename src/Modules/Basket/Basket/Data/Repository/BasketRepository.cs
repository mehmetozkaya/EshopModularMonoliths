
namespace Basket.Data.Repository;
public class BasketRepository(BasketDbContext dbContext)
    : IBasketRepository
{
    public async Task<ShoppingCart> GetBasket(string userName, bool asNoTracking = true, CancellationToken cancellationToken = default)
    {
        var query = dbContext.ShoppingCarts
            .Include(x => x.Items)
            .Where(x => x.UserName == userName);

        if (asNoTracking)
        {
            query.AsNoTracking();
        }

        var basket = await query.SingleOrDefaultAsync(cancellationToken);

        return basket ?? throw new BasketNotFoundException(userName);
    }

    public async Task<ShoppingCart> CreateBasket(ShoppingCart basket, CancellationToken cancellationToken = default)
    {
        dbContext.ShoppingCarts.Add(basket);
        await dbContext.SaveChangesAsync(cancellationToken);
        return basket;
    }

    public async Task<bool> DeleteBasket(string userName, CancellationToken cancellationToken = default)
    {
        var basket = await GetBasket(userName, false, cancellationToken);

        dbContext.ShoppingCarts.Remove(basket);
        await dbContext.SaveChangesAsync(cancellationToken);

        return true;
    }    

    public async Task<int> SaveChangesAsync(string? userName = null, CancellationToken cancellationToken = default)
    {
        return await dbContext.SaveChangesAsync(cancellationToken);
    }
}
