using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class IdentityResolutionConfig
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// Whether the channel should resolve identities
    /// </summary>
    /// <value>Whether the channel should resolve identities</value>
    public bool? ResolveIdentities { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
