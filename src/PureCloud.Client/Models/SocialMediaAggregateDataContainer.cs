namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaAggregateDataContainer
/// </summary>
public sealed class SocialMediaAggregateDataContainer
{
    /// <summary>
    /// A mapping from dimension to value
    /// </summary>
    /// <value>A mapping from dimension to value</value>
    public Dictionary<string, string> Group { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public IEnumerable<SocialMediaStatisticalResponse> Data { get; set; }
}