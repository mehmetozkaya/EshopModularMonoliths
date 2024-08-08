namespace Basket.Basket.Features.RemoveItemFromBasket;

//public record RemoveItemFromBasketRequest(string UserName, Guid ProductId);
public record RemoveItemFromBasketResponse(Guid Id);

public class RemoveItemFromBasketEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapDelete("/basket/{userName}/items/{productId}",
            async ([FromRoute] string userName, 
                   [FromRoute] Guid productId, 
                   ISender sender) =>
            {
                var command = new RemoveItemFromBasketCommand(userName, productId);

                var result = await sender.Send(command);

                var response = result.Adapt<RemoveItemFromBasketResponse>();

                return Results.Ok(response);
            })
        .Produces<RemoveItemFromBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Remove Item From Basket")
        .WithDescription("Remove Item From Basket")
        .RequireAuthorization();
    }
}
