namespace Catalog.Products.Features.GetProducts;

public record GetProductsQuery()
    : IQuery<GetProductsResult>;
public record GetProductsResult(IEnumerable<ProductDto> Products);

internal class GetProductsHandler(CatalogDbContext dbContext)
    : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        // get products using dbContext
        // return result

        var products = await dbContext.Products
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

        //mapping product entity to ProductDto using Mapster
        var productDtos = products.Adapt<List<ProductDto>>();

        return new GetProductsResult(productDtos);
    }
}
