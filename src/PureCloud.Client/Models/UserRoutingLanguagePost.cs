using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents an organization language assigned to a user. When assigning to a user specify the organization langauge id as the id.
/// </summary>

public partial class UserRoutingLanguagePost : IEquatable<UserRoutingLanguagePost>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingLanguagePost" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserRoutingLanguagePost() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingLanguagePost" /> class.
    /// </summary>
    /// <param name="Id">The id of the existing routing language to add to the user (required).</param>
    /// <param name="Proficiency">Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular language. It is used when a queue is set to \&quot;Best available language\&quot; mode to allow acd interactions to target agents with higher proficiency ratings. (required).</param>
    public UserRoutingLanguagePost(string Id = null, double? Proficiency = null)
    {
        this.Id = Id;
        this.Proficiency = Proficiency;

    }



    /// <summary>
    /// The id of the existing routing language to add to the user
    /// </summary>
    /// <value>The id of the existing routing language to add to the user</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular language. It is used when a queue is set to \&quot;Best available language\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.
    /// </summary>
    /// <value>Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular language. It is used when a queue is set to \&quot;Best available language\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.</value>
    [JsonPropertyName("proficiency")]
    public double? Proficiency { get; set; }



    /// <summary>
    /// URI to the organization language used by this user language.
    /// </summary>
    /// <value>URI to the organization language used by this user language.</value>
    [JsonPropertyName("languageUri")]
    public string LanguageUri { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserRoutingLanguagePost {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
        sb.Append("  LanguageUri: ").Append(LanguageUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as UserRoutingLanguagePost);
    }

    /// <summary>
    /// Returns true if UserRoutingLanguagePost instances are equal
    /// </summary>
    /// <param name="other">Instance of UserRoutingLanguagePost to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserRoutingLanguagePost other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Proficiency == other.Proficiency ||
                Proficiency != null &&
                Proficiency.Equals(other.Proficiency)
            ) &&
            (
                LanguageUri == other.LanguageUri ||
                LanguageUri != null &&
                LanguageUri.Equals(other.LanguageUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Proficiency != null)
            {
                hash = hash * 59 + Proficiency.GetHashCode();
            }

            if (LanguageUri != null)
            {
                hash = hash * 59 + LanguageUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
