using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Represents an organization skill assigned to a user. When assigning to a user specify the organization skill id as the id.
/// </summary>
[DataContract]
public partial class UserRoutingSkillPost : IEquatable<UserRoutingSkillPost>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingSkillPost" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserRoutingSkillPost() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingSkillPost" /> class.
    /// </summary>
    /// <param name="Id">The id of the existing routing skill to add to the user (required).</param>
    /// <param name="Proficiency">Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings. (required).</param>
    public UserRoutingSkillPost(string Id = null, double? Proficiency = null)
    {
        this.Id = Id;
        this.Proficiency = Proficiency;

    }



    /// <summary>
    /// The id of the existing routing skill to add to the user
    /// </summary>
    /// <value>The id of the existing routing skill to add to the user</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.
    /// </summary>
    /// <value>Proficiency is a rating from 0.0 to 5.0 on how competent an agent is for a particular skill. It is used when a queue is set to \&quot;Best available skills\&quot; mode to allow acd interactions to target agents with higher proficiency ratings.</value>
    [DataMember(Name = "proficiency", EmitDefaultValue = false)]
    public double? Proficiency { get; set; }



    /// <summary>
    /// URI to the organization skill used by this user skill.
    /// </summary>
    /// <value>URI to the organization skill used by this user skill.</value>
    [DataMember(Name = "skillUri", EmitDefaultValue = false)]
    public string SkillUri { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserRoutingSkillPost {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Proficiency: ").Append(Proficiency).Append("\n");
        sb.Append("  SkillUri: ").Append(SkillUri).Append("\n");
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
        return this.Equals(obj as UserRoutingSkillPost);
    }

    /// <summary>
    /// Returns true if UserRoutingSkillPost instances are equal
    /// </summary>
    /// <param name="other">Instance of UserRoutingSkillPost to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserRoutingSkillPost other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Proficiency == other.Proficiency ||
                this.Proficiency != null &&
                this.Proficiency.Equals(other.Proficiency)
            ) &&
            (
                this.SkillUri == other.SkillUri ||
                this.SkillUri != null &&
                this.SkillUri.Equals(other.SkillUri)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Proficiency != null)
            {
                hash = hash * 59 + this.Proficiency.GetHashCode();
            }

            if (this.SkillUri != null)
            {
                hash = hash * 59 + this.SkillUri.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
