using MediatR;

namespace Shared.Contracts.CQRS;
public interface IQuery<out T> : IRequest<T>
    where T : notnull
{
}
