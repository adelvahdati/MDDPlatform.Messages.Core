using MDDPlatform.Messages.Core;

namespace MDDPlatform.Messages.Queries
{
    public interface IQuery : IMessage
    {

    }
    public interface IQuery<TResult> : IQuery 
    {

    }
}