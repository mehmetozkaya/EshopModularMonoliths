namespace Catalog.Products.Events;
public record ProductCreatedEvent(Product Product)
    : IDomainEvent;
