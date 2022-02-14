namespace MDDPlatform.Messages.Core 
{
    public interface IWrappedMessage<T> where T : IMessage
    {
        T Body { get; set; }
        string MessageId { get; set; }
        string CorrelationId { get; set; }
        string MessageType { get; set; }
        string MessageContext { get; set; }
        IDictionary<string, object> Headers { get; set; }
    }
}