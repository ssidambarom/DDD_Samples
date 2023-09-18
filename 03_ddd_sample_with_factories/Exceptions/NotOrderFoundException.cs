using System.Runtime.Serialization;

namespace ddd_sample_03_with_factories;
[Serializable]
internal class NotOrderFoundException : Exception
{
    public NotOrderFoundException()
    {
    }

    public NotOrderFoundException(string? message) : base(message)
    {
    }

    public NotOrderFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotOrderFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
