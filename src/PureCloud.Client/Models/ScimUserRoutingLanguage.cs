using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// The routing language assigned to a user.
/// </summary>

public sealed class ScimUserRoutingLanguage
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserRoutingLanguage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimUserRoutingLanguage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserRoutingLanguage" /> class.
    /// </summary>
    /// <param name="Name">The case-sensitive name of a routing language configured in Genesys Cloud. (required).</param>
    /// <param name="Proficiency">A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings..</param>



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
    /// Returns true if ScimUserRoutingLanguage instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserRoutingLanguage to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
