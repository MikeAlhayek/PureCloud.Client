namespace PureCloud.Client.Models;

/// <summary>
/// ExpandableWebDeploymentEntityListing
/// </summary>
public sealed class ExpandableWebDeploymentEntityListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    /// <value>Gets or Sets Entities</value>
    public IEnumerable<ExpandableWebDeployment> Entities { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    /// <value>Gets or Sets NextUri</value>
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    /// <value>Gets or Sets SelfUri</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    /// <value>Gets or Sets PreviousUri</value>
    public string PreviousUri { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    /// <value>Gets or Sets Total</value>
    public long? Total { get; set; }
}