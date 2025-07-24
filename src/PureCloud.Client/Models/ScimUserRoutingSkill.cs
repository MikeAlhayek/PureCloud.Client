namespace PureCloud.Client.Models;

/// <summary>
/// The routing skill assigned to a user.
/// </summary>
public sealed class ScimUserRoutingSkill
{
    /// <summary>
    /// The case-sensitive name of a routing skill configured in Genesys Cloud.
    /// </summary>
    /// <value>The case-sensitive name of a routing skill configured in Genesys Cloud.</value>
    public string Name { get; set; }

    /// <summary>
    /// A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.
    /// </summary>
    /// <value>A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.</value>
    public double? Proficiency { get; set; }
}
