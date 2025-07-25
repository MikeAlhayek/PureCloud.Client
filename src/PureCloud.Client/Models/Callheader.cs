namespace PureCloud.Client.Models;

/// <summary>
/// Callheader
/// </summary>
public sealed class Callheader
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
    /// Parsed SIP headers.
    /// </summary>
    public IDictionary<string, IEnumerable<string>> Headers { get; set; }

    /// <summary>
    /// The URI for this object.
    /// </summary>
    public string SelfUri { get; set; }
}
