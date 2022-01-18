namespace MDDPlatform.Messages.Events
{
    public interface IEventHandler<TEvent> where TEvent : class, IEvent
    {
        Task HandleAsync(TEvent @event);
        void Handle(TEvent @event);

    }
}