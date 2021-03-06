using MDDPlatform.Messages.Commands;
using MDDPlatform.Messages.Events;
using MDDPlatform.Messages.Queries;

namespace MDDPlatform.Messages.Dispatchers 
{
    public interface IMessageDispatcher
    {
        Task HandleAsync(ICommand command);
        Task HandleAsync(IEvent @event);
        Task<TResult> HandleAsync<TResult>(IQuery<TResult> query);
    }

}