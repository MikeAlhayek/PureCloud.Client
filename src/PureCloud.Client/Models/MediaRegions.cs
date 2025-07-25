namespace PureCloud.Client.Models;

/// <summary>
/// MediaRegions
/// </summary>
public sealed class MediaRegions
{
    /// <summary>
    /// The AWS region your organization is in.
    /// </summary>
    public string AwsHomeRegion { get; set; }

    /// <summary>
    /// The list of AWS regions to which Genesys Cloud is deployed with full functionality including media streaming.
    /// </summary>
    public IEnumerable<string> AwsCoreRegions { get; set; }

    /// <summary>
    /// The list of AWS regions that Genesys Cloud uses only for media streaming.
    /// </summary>
    public IEnumerable<string> AwsSatelliteRegions { get; set; }
}
