using System.Runtime.Serialization;

namespace ddd_sample_04_with_domain_event;
[Serializable]
internal class InvalidDomainException : Exception
{
    public InvalidDomainException()
    {
    }

    public InvalidDomainException(string? message) : base(message)
    {
    }

    public InvalidDomainException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}