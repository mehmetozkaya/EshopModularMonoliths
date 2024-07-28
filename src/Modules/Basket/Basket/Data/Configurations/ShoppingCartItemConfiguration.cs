using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basket.Data.Configurations;
public class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItem>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(oi => oi.ProductId).IsRequired();

        builder.Property(oi => oi.Quantity).IsRequired();

        builder.Property(oi => oi.Color);

        builder.Property(oi => oi.Price).IsRequired();

        builder.Property(oi => oi.ProductName).IsRequired();
    }
}
