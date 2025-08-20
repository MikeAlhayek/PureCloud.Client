namespace PureCloud.Client.Models;

public sealed class ComparisonPeriodListing
{
    /// <summary>
    /// Total number of comparison periods
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// List of comparison periods
    /// </summary>
    public IEnumerable<ComparisonPeriod> Entities { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
