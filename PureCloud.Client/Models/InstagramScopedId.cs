using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Scoped ID for an Instagram user interacting with a page or app
/// </summary>
[DataContract]
public partial class InstagramScopedId : IEquatable<InstagramScopedId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InstagramScopedId" /> class.
    /// </summary>
    /// <param name="ScopedId">The unique page/app-specific scopedId for the user.</param>
    public InstagramScopedId(string ScopedId = null)
    {
        this.ScopedId = ScopedId;

    }



    /// <summary>
    /// The unique page/app-specific scopedId for the user
    /// </summary>
    /// <value>The unique page/app-specific scopedId for the user</value>
    [DataMember(Name = "scopedId", EmitDefaultValue = false)]
    public string ScopedId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InstagramScopedId {\n");

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
        return Equals(obj as InstagramScopedId);
    }

    /// <summary>
    /// Returns true if InstagramScopedId instances are equal
    /// </summary>
    /// <param name="other">Instance of InstagramScopedId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InstagramScopedId other)
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
