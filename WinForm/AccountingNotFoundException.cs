using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class AccountingNotFoundException : Exception
    {
        public AccountingNotFoundException()
        {
        }

        public AccountingNotFoundException(string? message) : base(message)
        {
        }

        public AccountingNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AccountingNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}