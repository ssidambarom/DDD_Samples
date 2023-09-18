using System.Runtime.Serialization;

namespace 02_ddd_sample_with_usecases;
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