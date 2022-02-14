using MDDPlatform.Messages.Events;

namespace MDDPlatform.Messages.Dispatchers
{
    public interface IEventDispatcher{
        Task HandleAsync<T> (T @event) where T: class,IEvent;
    }
}