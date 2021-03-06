﻿using System;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Security;

namespace NetOffice.Exceptions
{
    /// <summary>
    /// Extend System.Runtime.InteropServices.COMException
    /// </summary>
    public class NetOfficeCOMException : COMException
    {
        private Version _netOfficeVersion;

        private string _defaultApplicationVersion = "<Unknown>";

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public NetOfficeCOMException() : base()
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="inner">the exception that is the cause of the current exception</param>
        public NetOfficeCOMException(Exception inner) : base(null != inner ? inner.Message : "<Error>", inner)
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="message">the message that indicates the reason for the exception</param>
        public NetOfficeCOMException(string message) : base(message)
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="message">the message that indicates the reason for the exception</param>
        /// <param name="inner">the exception that is the cause of the current exception</param>
        public NetOfficeCOMException(string message, Exception inner) : base(message, inner)
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="message">the message that indicates the reason for the exception</param>
        /// <param name="errorCode">The error code (HRESULT) value associated with this exception</param>
        public NetOfficeCOMException(string message, int errorCode) : base(message, errorCode)
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="info">the SerializationInfo object that holds the serialized object data</param>
        /// <param name="context">the StreamingContext object that supplies the contextual information about the source or destination</param>
        /// <exception cref="ArgumentNullException">info is null</exception>
        [SecuritySafeCritical]
        public NetOfficeCOMException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ApplicationVersion = _defaultApplicationVersion;
        }

        /// <summary>
        /// Office product application version if available
        /// </summary>
        public string ApplicationVersion { get; internal set; }

        /// <summary>
        /// NetOffice Version
        /// </summary>
        public Version NetOfficeVersion
        {
            get
            {
                if (null == _netOfficeVersion)
                    _netOfficeVersion = typeof(NetOfficeException).Assembly.GetName().Version;
                return _netOfficeVersion;
            }
        }
    }
}
