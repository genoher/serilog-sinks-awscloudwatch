using System;
using System.Net;

namespace Serilog.Sinks.AwsCloudWatch
{
    /// <summary>
    /// DefaultLogStreamProvider
    /// </summary>
    /// <seealso cref="Serilog.Sinks.AwsCloudWatch.ILogStreamNameProvider" />
    public class DefaultLogStreamProvider : ILogStreamNameProvider
    {
        /// <summary>
        /// The datetime format
        /// </summary>
        private readonly string DATETIME_FORMAT = "yyyy-MM-dd-hh-mm-ss";

        /// <summary>
        /// Gets the log stream name.
        /// </summary>
        /// <returns></returns>
        public string GetLogStreamName()
        {
            return $"{DateTime.UtcNow.ToString(DATETIME_FORMAT)}_{Dns.GetHostName()}_{Guid.NewGuid()}";
        }
    }
}