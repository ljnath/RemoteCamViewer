using System;
using System.Runtime.Serialization;

namespace RemoteCamViewer.Exceptions
{
    [Serializable]
    public class MissingCamException : Exception
    {

        public MissingCamException() : base() { }

        public MissingCamException(string message) : base(message) { }

        public MissingCamException(string format, params object[] args) : base(string.Format(format, args)) { }

        public MissingCamException(string message, Exception innerException) : base(message, innerException) { }

        public MissingCamException(string format, Exception innerException, params object[] args) : base(string.Format(format, args), innerException) { }

        protected MissingCamException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
