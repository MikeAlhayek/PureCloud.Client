namespace PureCloud.Client.Models;

public sealed class RoutingSkill
{
    /// <summary>
    /// The current state for this skill.
    /// </summary>
    /// <value>The current state for this skill.</value>
    public RoutingSkillState? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the skill.
    /// </summary>
    /// <value>The name of the skill.</value>
    public string Name { get; set; }

    /// <summary>
    /// Date last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required when updating. Version must be the current version. Only the system can assign version.
    /// </summary>
    /// <value>Required when updating. Version must be the current version. Only the system can assign version.</value>
    public string Version { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
