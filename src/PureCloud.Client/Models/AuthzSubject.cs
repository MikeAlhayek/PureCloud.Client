using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthzSubject
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Grants
    /// </summary>
    public IEnumerable<AuthzGrant> Grants { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
