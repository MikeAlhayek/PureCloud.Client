using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthorizationPolicy
{
    /// <summary>
    /// The effect this policy should have when its conditions are met
    /// </summary>
    /// <value>The effect this policy should have when its conditions are met</value>
    public AuthorizationPolicyEffectEnum? Effect { get; set; }

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
    /// The targeted resource to which the policy should apply, in the form of domain:entity:action
    /// </summary>
    /// <value>The targeted resource to which the policy should apply, in the form of domain:entity:action</value>
    public string TargetResource { get; set; }

    /// <summary>
    /// The subject to whom the policy will apply, including type and id
    /// </summary>
    /// <value>The subject to whom the policy will apply, including type and id</value>
    public Subject Subject { get; set; }

    /// <summary>
    /// The condition tree the policy will evaluate
    /// </summary>
    /// <value>The condition tree the policy will evaluate</value>
    public object Condition { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this policy was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Map of names and values of preset attributes to use in policy evaluation
    /// </summary>
    /// <value>Map of names and values of preset attributes to use in policy evaluation</value>
    public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }

    /// <summary>
    /// Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.
    /// </summary>
    /// <value>Flag for active enforcement. If this value is false or null, the policy will be saved but will not be checked or enforced on users.</value>
    public bool? Active { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
