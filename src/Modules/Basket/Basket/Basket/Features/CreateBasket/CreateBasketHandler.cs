namespace Basket.Basket.Features.CreateBasket;

public record CreateBasketCommand(ShoppingCartDto ShoppingCart)
    : ICommand<CreateBasketResult>;
public record CreateBasketResult(Guid Id);
public class CreateBasketCommandValidator : AbstractValidator<CreateBasketCommand>
{
    public CreateBasketCommandValidator()
    {
        RuleFor(x => x.ShoppingCart.UserName).NotEmpty().WithMessage("UserName is required");
    }
}

internal class CreateBasketHandler(IBasketRepository repository)
    : ICommandHandler<CreateBasketCommand, CreateBasketResult>
{
    public async Task<CreateBasketResult> Handle(CreateBasketCommand command, CancellationToken cancellationToken)
    {
        //create Basket entity from command object
        //save to database
        //return result

        var shoppingCart = CreateNewBasket(command.ShoppingCart);        

        await repository.CreateBasket(shoppingCart, cancellationToken);

        return new CreateBasketResult(shoppingCart.Id);
    }

    private ShoppingCart CreateNewBasket(ShoppingCartDto shoppingCartDto)
    {
        // create new basket
        var newBasket = ShoppingCart.Create(
            Guid.NewGuid(),
            shoppingCartDto.UserName);

        shoppingCartDto.Items.ForEach(item =>
        {
            newBasket.AddItem(
                item.ProductId,
                item.Quantity,
                item.Color,
                item.Price,
                item.ProductName);
        });

        return newBasket;
    }
}
