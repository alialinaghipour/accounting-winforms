using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class MobileIsDuplicatedException : Exception
    {
        public MobileIsDuplicatedException()
        {
        }

        public MobileIsDuplicatedException(string? message) : base(message)
        {
        }

        public MobileIsDuplicatedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MobileIsDuplicatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}