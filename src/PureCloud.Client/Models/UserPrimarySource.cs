namespace PureCloud.Client.Models;

/// <summary>
/// UserPrimarySource
/// </summary>
public sealed class UserPrimarySource
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The id of the source
    /// </summary>
    public string SourceId { get; set; }

    /// <summary>
    /// Whether or not the source is registered
    /// </summary>
    public bool? Registered { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
