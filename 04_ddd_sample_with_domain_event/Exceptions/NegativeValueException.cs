using System.Runtime.Serialization;

namespace ddd_sample_04_with_domain_event;

[Serializable]
internal class NegativeValueException : Exception
{
    public NegativeValueException()
    {
    }

    public NegativeValueException(string? message) : base(message)
    {
    }

    public NegativeValueException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}