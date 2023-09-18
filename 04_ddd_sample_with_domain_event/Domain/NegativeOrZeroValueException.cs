using System.Runtime.Serialization;

namespace ddd_sample_04_with_domain_event;

[Serializable]
internal class NegativeOrZeroValueException : Exception
{
    public NegativeOrZeroValueException()
    {
    }

    public NegativeOrZeroValueException(string? propertyName) : base($"\"{propertyName}\" cannot be negative or zero.")
    {
    }

    public NegativeOrZeroValueException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeOrZeroValueException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}