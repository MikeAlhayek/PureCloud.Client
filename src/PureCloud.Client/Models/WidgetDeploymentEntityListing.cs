namespace PureCloud.Client.Models;

/// <summary>
/// WidgetDeploymentEntityListing
/// </summary>
public sealed class WidgetDeploymentEntityListing
{
    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WidgetDeployment> Entities { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}