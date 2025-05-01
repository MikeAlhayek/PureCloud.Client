using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialTopicPatchRequest
/// </summary>
[DataContract]
public partial class SocialTopicPatchRequest : IEquatable<SocialTopicPatchRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialTopicPatchRequest" /> class.
    /// </summary>
    /// <param name="Name">Name of the social topic..</param>
    /// <param name="Description">A description of the social topic..</param>
    /// <param name="DivisionId">The ID of the division the social topic currently belongs to OR which it should be moved to..</param>
    public SocialTopicPatchRequest(string Name = null, string Description = null, string DivisionId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// Name of the social topic.
    /// </summary>
    /// <value>Name of the social topic.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// A description of the social topic.
    /// </summary>
    /// <value>A description of the social topic.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the division the social topic currently belongs to OR which it should be moved to.
    /// </summary>
    /// <value>The ID of the division the social topic currently belongs to OR which it should be moved to.</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialTopicPatchRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
        return Equals(obj as SocialTopicPatchRequest);
    }

    /// <summary>
    /// Returns true if SocialTopicPatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialTopicPatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialTopicPatchRequest other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            return hash;
        }
    }
}
