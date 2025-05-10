namespace PureCloud.Client.Models;

public sealed class Disposition
{
    /// <summary>
    /// Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..
    /// </summary>
    /// <value>Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..</value>
    public string Name { get; set; }

    /// <summary>
    /// The final media analyzer result that triggered the disposition result, if any.
    /// </summary>
    /// <value>The final media analyzer result that triggered the disposition result, if any.</value>
    public string Analyzer { get; set; }

    /// <summary>
    /// Contains various parameters related to call analysis.
    /// </summary>
    /// <value>Contains various parameters related to call analysis.</value>
    public DispositionParameters DispositionParameters { get; set; }

    /// <summary>
    /// Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DetectedSpeechStart { get; set; }

    /// <summary>
    /// Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DetectedSpeechEnd { get; set; }
}
