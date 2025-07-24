namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaAsyncAggregateQueryResponse
/// </summary>
public sealed class SocialMediaAsyncAggregateQueryResponse
{
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<SocialMediaAggregateDataContainer> Results { get; set; }

    /// <summary>
    /// Cursor token to retrieve next page
    /// </summary>
    /// <value>Cursor token to retrieve next page</value>
    public string Cursor { get; set; }
}