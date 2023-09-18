using System.Runtime.Serialization;

namespace ddd_sample_04_with_domain_event;
[Serializable]
internal class TooManyOrderItemException : Exception
{
    public TooManyOrderItemException()
    {
    }

    public TooManyOrderItemException(string? message) : base(message)
    {
    }

    public TooManyOrderItemException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected TooManyOrderItemException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}