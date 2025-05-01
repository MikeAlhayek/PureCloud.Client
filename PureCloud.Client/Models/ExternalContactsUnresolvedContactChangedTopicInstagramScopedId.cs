using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicInstagramScopedId
/// </summary>
[DataContract]
public partial class ExternalContactsUnresolvedContactChangedTopicInstagramScopedId : IEquatable<ExternalContactsUnresolvedContactChangedTopicInstagramScopedId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicInstagramScopedId" /> class.
    /// </summary>
    /// <param name="ScopedId">ScopedId.</param>
    public ExternalContactsUnresolvedContactChangedTopicInstagramScopedId(string ScopedId = null)
    {
        this.ScopedId = ScopedId;

    }



    /// <summary>
    /// Gets or Sets ScopedId
    /// </summary>
    [DataMember(Name = "scopedId", EmitDefaultValue = false)]
    public string ScopedId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicInstagramScopedId {\n");

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
        return this.Equals(obj as ExternalContactsUnresolvedContactChangedTopicInstagramScopedId);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicInstagramScopedId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicInstagramScopedId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicInstagramScopedId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.ScopedId == other.ScopedId ||
                this.ScopedId != null &&
                this.ScopedId.Equals(other.ScopedId)
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
            if (this.ScopedId != null)
            {
                hash = hash * 59 + this.ScopedId.GetHashCode();
            }

            return hash;
        }
    }
}
