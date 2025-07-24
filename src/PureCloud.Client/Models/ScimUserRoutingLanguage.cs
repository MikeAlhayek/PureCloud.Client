namespace PureCloud.Client.Models;

/// <summary>
/// The routing language assigned to a user.
/// </summary>
public sealed class ScimUserRoutingLanguage
{
    /// <summary>
    /// The case-sensitive name of a routing language configured in Genesys Cloud.
    /// </summary>
    /// <value>The case-sensitive name of a routing language configured in Genesys Cloud.</value>
    public string Name { get; set; }

    /// <summary>
    /// A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.
    /// </summary>
    /// <value>A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.</value>
    public double? Proficiency { get; set; }
}
