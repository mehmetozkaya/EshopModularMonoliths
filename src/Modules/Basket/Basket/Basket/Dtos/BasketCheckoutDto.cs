namespace Basket.Basket.Dtos;
public record BasketCheckoutDto(
    string UserName,
    Guid CustomerId,
    decimal TotalPrice,
    // Shipping and BillingAddress
    string FirstName,
    string LastName,
    string EmailAddress,
    string AddressLine,
    string Country,
    string State,
    string ZipCode,
    //Payment
    string CardName,
    string CardNumber,
    string Expiration,
    string Cvv,
    int PaymentMethod
    );
