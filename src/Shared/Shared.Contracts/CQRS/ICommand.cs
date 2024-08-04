using MediatR;

namespace Shared.Contracts.CQRS;
public interface ICommand : ICommand<Unit>
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
