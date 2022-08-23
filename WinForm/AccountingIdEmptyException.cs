using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class AccountingIdEmptyException : Exception
    {
        public AccountingIdEmptyException()
        {
        }

        public AccountingIdEmptyException(string? message) : base(message)
        {
        }

        public AccountingIdEmptyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AccountingIdEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}