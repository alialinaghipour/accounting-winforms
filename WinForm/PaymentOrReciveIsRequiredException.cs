using System.Runtime.Serialization;

namespace WinForm
{
    [Serializable]
    internal class PaymentOrReciveIsRequiredException : Exception
    {
        public PaymentOrReciveIsRequiredException()
        {
        }

        public PaymentOrReciveIsRequiredException(string? message) : base(message)
        {
        }

        public PaymentOrReciveIsRequiredException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PaymentOrReciveIsRequiredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}