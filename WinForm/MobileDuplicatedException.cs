using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class MobileRequiredException : Exception
    {
        public MobileRequiredException()
        {
        }

        public MobileRequiredException(string? message) : base(message)
        {
        }

        public MobileRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MobileRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}