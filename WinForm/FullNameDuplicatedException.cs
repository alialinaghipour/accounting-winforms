using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class FullNameRequiredException : Exception
    {
        public FullNameRequiredException()
        {
        }

        public FullNameRequiredException(string? message) : base(message)
        {
        }

        public FullNameRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FullNameRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}