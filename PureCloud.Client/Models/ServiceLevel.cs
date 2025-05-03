namespace PureCloud.Client.Models;

public sealed class ServiceLevel
{
    /// <summary>
    /// The desired Service Level. A value between 0 and 1.
    /// </summary>
    /// <value>The desired Service Level. A value between 0 and 1.</value>
    public double? Percentage { get; set; }

    /// <summary>
    /// Service Level target in milliseconds.
    /// </summary>
    /// <value>Service Level target in milliseconds.</value>
    public long? DurationMs { get; set; }
}
