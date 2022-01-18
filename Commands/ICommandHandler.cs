namespace MDDPlatform.Messages.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : class, ICommand
    {
        Task HandleAsync(TCommand command);
        void Handle(TCommand command);
    }
}