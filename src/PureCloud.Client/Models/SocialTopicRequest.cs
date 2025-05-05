using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialTopicRequest
/// </summary>

public partial class SocialTopicRequest : IEquatable<SocialTopicRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SocialTopicRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SocialTopicRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialTopicRequest" /> class.
    /// </summary>
    /// <param name="Name">Name of the social topic. (required).</param>
    /// <param name="Description">A description of the social topic..</param>
    /// <param name="DivisionId">The ID of the division the social topic belongs to. (required).</param>
    public SocialTopicRequest(string Name = null, string Description = null, string DivisionId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// Name of the social topic.
    /// </summary>
    /// <value>Name of the social topic.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the social topic.
    /// </summary>
    /// <value>A description of the social topic.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the division the social topic belongs to.
    /// </summary>
    /// <value>The ID of the division the social topic belongs to.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialTopicRequest {\n");

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
        return Equals(obj as SocialTopicRequest);
    }

    /// <summary>
    /// Returns true if SocialTopicRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialTopicRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialTopicRequest other)
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
