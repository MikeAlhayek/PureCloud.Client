using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// The routing skill assigned to a user.
/// </summary>

public sealed class ScimUserRoutingSkill
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimUserRoutingSkill() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserRoutingSkill" /> class.
    /// </summary>
    /// <param name="Name">The case-sensitive name of a routing skill configured in Genesys Cloud. (required).</param>
    /// <param name="Proficiency">A rating from 0.0 to 5.0 that indicates how adept an agent is at a particular skill. When \&quot;Best available skills\&quot; is enabled for a queue in Genesys Cloud, ACD interactions in that queue are routed to agents with higher proficiency ratings..</param>



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


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if ScimUserRoutingSkill instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserRoutingSkill to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
