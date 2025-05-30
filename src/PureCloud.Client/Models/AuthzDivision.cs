using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthzDivision
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
    /// A helpful description for the division.
    /// </summary>
    /// <value>A helpful description for the division.</value>
    public string Description { get; set; }

    /// <summary>
    /// A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.
    /// </summary>
    /// <value>A flag indicating whether this division is the \&quot;Home\&quot; (default) division. Cannot be modified and any supplied value will be ignored on create or update.</value>
    public bool? HomeDivision { get; set; }

    /// <summary>
    /// A count of objects in this division, grouped by type.
    /// </summary>
    /// <value>A count of objects in this division, grouped by type.</value>
    public Dictionary<string, long?> ObjectCounts { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
