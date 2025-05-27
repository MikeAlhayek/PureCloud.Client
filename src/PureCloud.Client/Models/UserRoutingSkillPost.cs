using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserRoutingSkillPost
{
    /// <summary>
    /// The id of the existing routing skill to add to the user
    /// </summary>
    /// <value>The id of the existing routing skill to add to the user</value>
    public string Id { get; set; }

    /// <summary>
    /// Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.
    /// </summary>
    /// <value>Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.</value>
    public double? Proficiency { get; set; }

    /// <summary>
    /// URI to the organization skill used by this user skill.
    /// </summary>
    /// <value>URI to the organization skill used by this user skill.</value>
    public string SkillUri { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
