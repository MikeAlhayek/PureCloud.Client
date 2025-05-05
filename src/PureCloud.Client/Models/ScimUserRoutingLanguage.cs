using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The routing language assigned to a user.
/// </summary>

public partial class ScimUserRoutingLanguage : IEquatable<ScimUserRoutingLanguage>
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
    public ScimUserRoutingLanguage(string Name = null, double? Proficiency = null)
    {
        this.Name = Name;
        this.Proficiency = Proficiency;

    }



    /// <summary>
    /// The case-sensitive name of a routing language configured in Genesys Cloud.
    /// </summary>
    /// <value>The case-sensitive name of a routing language configured in Genesys Cloud.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.
    /// </summary>
    /// <value>A rating from 0.0 to 5.0 that indicates how fluent an agent is in a particular language. ACD interactions are routed to agents with higher proficiency ratings.</value>
    [JsonPropertyName("proficiency")]
    public double? Proficiency { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimUserRoutingLanguage {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ScimUserRoutingLanguage);
    }

    /// <summary>
    /// Returns true if ScimUserRoutingLanguage instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserRoutingLanguage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimUserRoutingLanguage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Proficiency == other.Proficiency ||
                Proficiency != null &&
                Proficiency.Equals(other.Proficiency)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Proficiency != null)
            {
                hash = hash * 59 + Proficiency.GetHashCode();
            }

            return hash;
        }
    }
}
