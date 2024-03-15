using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class DayException : Exception
    {
        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

#pragma warning disable SYSLIB0051 // Type or member is obsolete
        public DayException(SerializationInfo info, StreamingContext context) : base(info, context)
#pragma warning restore SYSLIB0051 // Type or member is obsolete
        {
        }
    }
}