﻿using System;

namespace Serilog.Sinks.AwsCloudWatch
{
    /// <summary>
    /// ConstantLogStreamNameProvider
    /// </summary>
    /// <seealso cref="Serilog.Sinks.AwsCloudWatch.ILogStreamNameProvider" />
    public class ConstantLogStreamNameProvider : ILogStreamNameProvider
    {
        /// <summary>
        /// The prefix
        /// </summary>
        private readonly string _prefix;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantLogStreamNameProvider"/> class.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        public ConstantLogStreamNameProvider(string prefix)
        {
            _prefix = prefix ?? string.Empty;
        }

        /// <summary>
        /// Gets the log stream name.
        /// </summary>
        /// <returns></returns>
        public string GetLogStreamName()
        {
            return $"{_prefix}_{Guid.NewGuid()}";
        }
    }
}