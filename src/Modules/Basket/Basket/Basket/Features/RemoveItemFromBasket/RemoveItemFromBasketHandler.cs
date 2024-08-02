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

internal class RemoveItemFromBasketHandler(IBasketRepository repository)
    : ICommandHandler<RemoveItemFromBasketCommand, RemoveItemFromBasketResult>
{
    public async Task<RemoveItemFromBasketResult> Handle(RemoveItemFromBasketCommand command, CancellationToken cancellationToken)
    {
        var shoppingCart = await repository.GetBasket(command.UserName, false, cancellationToken);

        shoppingCart.RemoveItem(command.ProductId);

        await repository.SaveChangesAsync(command.UserName, cancellationToken);

        return new RemoveItemFromBasketResult(shoppingCart.Id);
    }
}
