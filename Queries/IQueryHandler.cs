namespace MDDPlatform.Messages.Queries
{
    public interface IQueryHandler<TQuery,TResult> where TQuery : class, IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
        TResult Handle(TQuery query);
    }
}