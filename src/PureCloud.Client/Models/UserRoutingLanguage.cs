namespace PureCloud.Client.Models;

public sealed class UserRoutingLanguage
{
    /// <summary>
    /// Activate or deactivate this routing language.
    /// </summary>
    /// <value>Activate or deactivate this routing language.</value>
    public UserRoutingLanguageState? State { get; set; }

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
    /// A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.
    /// </summary>
    /// <value>A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.</value>
    public double? Proficiency { get; set; }

    /// <summary>
    /// URI to the organization language used by this user language.
    /// </summary>
    /// <value>URI to the organization language used by this user language.</value>
    public string LanguageUri { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
