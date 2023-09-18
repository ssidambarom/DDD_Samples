using System.Runtime.Serialization;

[Serializable]
internal class NonMatchingCurrencyException : Exception
{
    public NonMatchingCurrencyException()
    {
    }

    public NonMatchingCurrencyException(string? message) : base(message)
    {
    }

    public NonMatchingCurrencyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NonMatchingCurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}