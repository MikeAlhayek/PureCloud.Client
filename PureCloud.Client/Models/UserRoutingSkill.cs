namespace PureCloud.Client.Models;

public sealed class UserRoutingSkill
{
    /// <summary>
    /// Activate or deactivate this routing skill.
    /// </summary>
    /// <value>Activate or deactivate this routing skill.</value>
    public UserRoutingSkillState? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; private set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.
    /// </summary>
    /// <value>A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings.</value>
    public double? Proficiency { get; set; }

    /// <summary>
    /// URI to the organization skill used by this user skill.
    /// </summary>
    /// <value>URI to the organization skill used by this user skill.</value>
    public string SkillUri { get; private set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; private set; }
}
