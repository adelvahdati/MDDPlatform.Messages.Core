using MDDPlatform.Messages.Queries;

namespace MDDPlatform.Messages.Dispatchers
{
    public interface IQueryDispatcher 
    {
        Task<TResult> HandleAsync<TResult>(IQuery query);
    }
}