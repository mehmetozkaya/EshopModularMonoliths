namespace Ordering.Orders.Dtos;
public record PaymentDto(string CardName, string CardNumber, string Expiration, string Cvv, int PaymentMethod);
