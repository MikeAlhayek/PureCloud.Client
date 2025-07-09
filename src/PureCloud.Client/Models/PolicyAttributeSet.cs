using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PolicyAttributeSet
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
    /// A set of the attributes checked by the requested policy.
    /// </summary>
    /// <value>A set of the attributes checked by the requested policy.</value>
    public IEnumerable<PolicyAttribute> PolicyAttributes { get; set; }

    /// <summary>
    /// Map of names and values of preset attributes used in this policy.
    /// </summary>
    /// <value>Map of names and values of preset attributes used in this policy.</value>
    public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
