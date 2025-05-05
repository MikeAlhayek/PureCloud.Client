using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicFacebookScopedId
/// </summary>

public partial class ExternalContactsUnresolvedContactChangedTopicFacebookScopedId : IEquatable<ExternalContactsUnresolvedContactChangedTopicFacebookScopedId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicFacebookScopedId" /> class.
    /// </summary>
    /// <param name="ScopedId">ScopedId.</param>
    public ExternalContactsUnresolvedContactChangedTopicFacebookScopedId(string ScopedId = null)
    {
        this.ScopedId = ScopedId;

    }



    /// <summary>
    /// Gets or Sets ScopedId
    /// </summary>
    [JsonPropertyName("scopedId")]
    public string ScopedId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicFacebookScopedId {\n");

        sb.Append("  ScopedId: ").Append(ScopedId).Append("\n");
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
        return Equals(obj as ExternalContactsUnresolvedContactChangedTopicFacebookScopedId);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicFacebookScopedId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicFacebookScopedId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicFacebookScopedId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScopedId == other.ScopedId ||
                ScopedId != null &&
                ScopedId.Equals(other.ScopedId)
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
            if (ScopedId != null)
            {
                hash = hash * 59 + ScopedId.GetHashCode();
            }

            return hash;
        }
    }
}
