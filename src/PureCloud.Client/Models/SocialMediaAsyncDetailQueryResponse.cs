namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaAsyncDetailQueryResponse
/// </summary>
public sealed class SocialMediaAsyncDetailQueryResponse
{
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<SocialMediaDetailDataContainer> Results { get; set; }

    /// <summary>
    /// Cursor token to retrieve next or previous page
    /// </summary>
    /// <value>Cursor token to retrieve next or previous page</value>
    public string Cursor { get; set; }
}