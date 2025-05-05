using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WemEngagementCelebrationUpdatesTopicUserId
/// </summary>

public partial class V2WemEngagementCelebrationUpdatesTopicUserId : IEquatable<V2WemEngagementCelebrationUpdatesTopicUserId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicUserId" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    public V2WemEngagementCelebrationUpdatesTopicUserId(Guid? Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WemEngagementCelebrationUpdatesTopicUserId {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as V2WemEngagementCelebrationUpdatesTopicUserId);
    }

    /// <summary>
    /// Returns true if V2WemEngagementCelebrationUpdatesTopicUserId instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicUserId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WemEngagementCelebrationUpdatesTopicUserId other)
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

            return hash;
        }
    }
}
