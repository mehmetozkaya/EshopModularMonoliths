namespace Catalog.Products.Features.UpdateProduct;

public record UpdateProductCommand(ProductDto Product)
    : ICommand<UpdateProductResult>;

public record UpdateProductResult(bool IsSuccess);

internal class UpdateProductHandler(CatalogDbContext dbContext)
    : ICommandHandler<UpdateProductCommand, UpdateProductResult>
{
    public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        //Update Product entity from command object
        //save to database
        //return result

        var product = await dbContext.Products
          .FindAsync([command.Product.Id], cancellationToken: cancellationToken);

        if (product is null)
        {
            throw new Exception($"Product not found: {command.Product.Id}");
        }

        UpdateProductWithNewValues(product, command.Product);

        dbContext.Products.Update(product);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new UpdateProductResult(true);
    }

    private void UpdateProductWithNewValues(Product product, ProductDto productDto)
    {
        product.Update(
            productDto.Name,
            productDto.Category,
            productDto.Description,
            productDto.ImageFile,
            productDto.Price);
    }
}
