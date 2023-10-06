using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class MissisngMemberException : Exception
    {
        public MissisngMemberException()
        {
        }

        public MissisngMemberException(string message) : base(message)
        {
        }

        public MissisngMemberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissisngMemberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}