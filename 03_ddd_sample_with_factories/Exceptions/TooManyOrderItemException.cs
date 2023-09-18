using System.Runtime.Serialization;

namespace ddd_sample_03_with_factories;
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