using log4net;
using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace RemoteCamViewer.Exceptions
{
    [Serializable]
    public class CameraException : Exception
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public CameraException() : base() { }

        public CameraException(string message) : base(message) { log.Error(message); }

        public CameraException(string format, params object[] args) : base(string.Format(format, args)) { }

        public CameraException(string message, Exception innerException) : base(message, innerException) { }

        public CameraException(string format, Exception innerException, params object[] args) : base(string.Format(format, args), innerException) { }

        protected CameraException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
