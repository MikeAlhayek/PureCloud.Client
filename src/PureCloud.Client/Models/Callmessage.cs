namespace PureCloud.Client.Models;

/// <summary>
/// Callmessage
/// </summary>
public sealed class Callmessage
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
    /// raw SIP message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
