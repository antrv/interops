using System;
using System.Runtime.Serialization;

namespace Antrv.Interop
{
    /// <summary>
    /// The base exception class for Interop issues.
    /// </summary>
    [Serializable]
    public class InteropException : Exception
    {
        public InteropException()
        {
        }

        public InteropException(string message)
            : base(message)
        {
        }

        public InteropException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected InteropException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
