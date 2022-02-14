using MDDPlatform.Messages.Commands;

namespace MDDPlatform.Messages.Dispatchers
{
    public interface ICommandDispatcher
    {
        Task HandleAsync<T>(T command) where T : class, ICommand;
    }

}