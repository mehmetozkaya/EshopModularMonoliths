namespace Basket.Basket.Features.RemoveItemFromBasket;

public record RemoveItemFromBasketCommand(string UserName, Guid ProductId)
    : ICommand<RemoveItemFromBasketResult>;
public record RemoveItemFromBasketResult(Guid Id);
public class RemoveItemFromBasketCommandValidator : AbstractValidator<RemoveItemFromBasketCommand>
{
    public RemoveItemFromBasketCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
        RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required");
    }
}

internal class RemoveItemFromBasketHandler(BasketDbContext dbContext)
    : ICommandHandler<RemoveItemFromBasketCommand, RemoveItemFromBasketResult>
{
    public async Task<RemoveItemFromBasketResult> Handle(RemoveItemFromBasketCommand command, CancellationToken cancellationToken)
    {
        var shoppingCart = await dbContext.ShoppingCarts
            .Include(x => x.Items)
            .SingleOrDefaultAsync(x => x.UserName == command.UserName, cancellationToken);

        if (shoppingCart is null)
        {
            throw new BasketNotFoundException(command.UserName);
        }

        shoppingCart.RemoveItem(command.ProductId);

        await dbContext.SaveChangesAsync(cancellationToken);

        return new RemoveItemFromBasketResult(shoppingCart.Id);
    }
}
