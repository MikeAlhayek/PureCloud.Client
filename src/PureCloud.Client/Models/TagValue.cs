using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TagValue
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The workspace tag name.
    /// </summary>
    /// <value>The workspace tag name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets InUse
    /// </summary>
    public bool? InUse { get; set; }

    /// <summary>
    /// Gets or Sets Acl
    /// </summary>
    public IEnumerable<string> Acl { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
