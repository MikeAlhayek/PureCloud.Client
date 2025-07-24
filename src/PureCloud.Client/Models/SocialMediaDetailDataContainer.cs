namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaDetailDataContainer
/// </summary>
public sealed class SocialMediaDetailDataContainer
{
    /// <summary>
    /// Gets or Sets Interval
    /// </summary>
    public string Interval { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    public IEnumerable<SocialMediaDetailMessageContainer> Messages { get; set; }
}