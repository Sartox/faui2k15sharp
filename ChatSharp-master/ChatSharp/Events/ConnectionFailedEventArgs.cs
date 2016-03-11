using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatSharp.Events
{
    /// <summary>
    /// Provides Information about an connection failure.
    /// </summary>
    public class ConnectionFailedEventArgs : EventArgs
    {
        /// <summary>
        /// extended
        /// </summary>
        /// <param name="ex">Exception occured on connection</param>
        public ConnectionFailedEventArgs(Exception ex)
        {
            Exception = ex;
        }
        /// <summary>
        /// default
        /// </summary>
        public Exception Exception
        {
            get;
            private set;
        }
    }
}
