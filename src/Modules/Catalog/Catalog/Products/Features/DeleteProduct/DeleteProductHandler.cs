namespace Catalog.Products.Features.DeleteProduct;

public record DeleteProductCommand(Guid ProductId)
    : ICommand<DeleteProductResult>;
public record DeleteProductResult(bool IsSuccess);

internal class DeleteProductHandler(CatalogDbContext dbContext)
    : ICommandHandler<DeleteProductCommand, DeleteProductResult>
{
    public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        //Delete Product entity from command object
        //save to database
        //return result

        var product = await dbContext.Products
           .FindAsync([command.ProductId], cancellationToken: cancellationToken);

        if (product is null)
        {
            throw new Exception($"Product not found: {command.ProductId}");
        }

        dbContext.Products.Remove(product);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new DeleteProductResult(true);
    }
}
