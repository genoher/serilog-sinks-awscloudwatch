using Serilog.Events;
using Serilog.Formatting;
using System;

namespace Serilog.Sinks.AwsCloudWatch
{
    /// <summary>
    /// The number of days to retain the log events in the specified log group.
    /// <see href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutRetentionPolicy.html"/>
    /// </summary>
    public enum LogGroupRetentionPolicy
    {
        /// <summary>
        /// The indefinitely = 0
        /// </summary>
        Indefinitely = 0,
        /// <summary>
        /// The one day = 1
        /// </summary>
        OneDay = 1,
        /// <summary>
        /// The three days = 3
        /// </summary>
        ThreeDays = 3,
        /// <summary>
        /// The five days = 5
        /// </summary>
        FiveDays = 5,
        /// <summary>
        /// The one week = 7
        /// </summary>
        OneWeek = 7,
        /// <summary>
        /// The two weeks = 14
        /// </summary>
        TwoWeeks = 14,
        /// <summary>
        /// The one month = 30
        /// </summary>
        OneMonth = 30,
        /// <summary>
        /// The two months = 60
        /// </summary>
        TwoMonths = 60,
        /// <summary>
        /// The three months = 90
        /// </summary>
        ThreeMonths = 90,
        /// <summary>
        /// The four months = 120
        /// </summary>
        FourMonths = 120,
        /// <summary>
        /// The five months = 150
        /// </summary>
        FiveMonths = 150,
        /// <summary>
        /// The six months = 180
        /// </summary>
        SixMonths = 180,
        /// <summary>
        /// The one year = 365
        /// </summary>
        OneYear = 365,
        /// <summary>
        /// The one year and one month = 400
        /// </summary>
        OneYearAndOneMonth = 400,
        /// <summary>
        /// The one year and six months = 545
        /// </summary>
        OneYearAndSixMonths = 545,
        /// <summary>
        /// The two years = 731
        /// </summary>
        TwoYears = 731,
        /// <summary>
        /// The three years = 1096
        /// </summary>
        ThreeYears = 1096,
        /// <summary>
        /// The five years = 1827
        /// </summary>
        FiveYears = 1827,
        /// <summary>
        /// The six years = 2192
        /// </summary>
        SixYears = 2192,
        /// <summary>
        /// The seven years = 2557
        /// </summary>
        SevenYears = 2557,
        /// <summary>
        /// The eight years = 2922
        /// </summary>
        EightYears = 2922,
        /// <summary>
        /// The nine years = 3288
        /// </summary>
        NineYears = 3288,
        /// <summary>
        /// The ten years = 3653
        /// </summary>
        TenYears = 3653
    }
}
