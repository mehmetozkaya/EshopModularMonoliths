using MediatR;

namespace Shared.CQRS;
public interface IQuery<out T> : IRequest<T>
    where T : notnull
{
}
