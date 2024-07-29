namespace Basket.Basket.Features.GetBasket;

public record GetBasketQuery(string UserName)
    : IQuery<GetBasketResult>;
public record GetBasketResult(ShoppingCartDto ShoppingCart);

internal class GetBasketHandler(BasketDbContext dbContext)
    : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        // get basket with userName
        var basket = await dbContext.ShoppingCarts
            .AsNoTracking()
            .Include(x => x.Items)
            .SingleOrDefaultAsync(x => x.UserName == query.UserName, cancellationToken);

        if (basket is null)
        {
            throw new BasketNotFoundException(query.UserName);
        }

        //mapping basket entity to shoppingcartdto
        var basketDto = basket.Adapt<ShoppingCartDto>();

        return new GetBasketResult(basketDto);
    }
}
