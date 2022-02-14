using MDDPlatform.Messages.Commands;
using MDDPlatform.Messages.Core;
using MDDPlatform.Messages.Events;

namespace MDDPlatform.Messages.Brokers{
    public interface IMessageBroker
    {
        Task PublishAsync(IEvent @event);
        Task PublishAsync(IEnumerable<IEvent> events);
        Task PublishAsync<TEvent>(IWrappedMessage<TEvent> @event) where TEvent:IEvent;
        
        Task SendAsync(ICommand command);
        Task SendAsync(IEnumerable<ICommand> commands);
        Task SendAsync<TCommand>(IWrappedMessage<TCommand> command) where TCommand:ICommand;        

        Task SubscribeAsync<TMessage>() where TMessage : IMessage;
    }
}