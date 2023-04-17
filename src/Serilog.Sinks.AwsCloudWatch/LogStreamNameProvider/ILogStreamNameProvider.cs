namespace Serilog.Sinks.AwsCloudWatch
{
    /// <summary>
    /// ILogStreamNameProvider. Gets the log stream name
    /// </summary>
    public interface ILogStreamNameProvider
    {
        /// <summary>
        /// Gets the log stream name.
        /// </summary>
        /// <returns></returns>
        string GetLogStreamName();
    }
}