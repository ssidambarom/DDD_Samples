using System.Runtime.Serialization;

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