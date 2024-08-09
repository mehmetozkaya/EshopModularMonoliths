using Shared.Exceptions;

namespace Ordering.Orders.Exceptions;
public class OrderNotFoundException(Guid orderId)
     : NotFoundException("Order", orderId)
{
}
