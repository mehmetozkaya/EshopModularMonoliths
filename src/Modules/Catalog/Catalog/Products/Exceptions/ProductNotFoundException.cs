using Shared.Exceptions;

namespace Catalog.Products.Exceptions;
public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(Guid id) 
        : base("Product", id)
    {
    }
}
