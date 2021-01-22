using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class MultiplyByZeroException : Exception
    {
        public MultiplyByZeroException()
        {
        }

        public MultiplyByZeroException(string message) : base(message)
        {
        }

        public MultiplyByZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MultiplyByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}