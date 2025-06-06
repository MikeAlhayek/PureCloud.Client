using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicGroupQueryPreview
/// </summary>

public partial class DynamicGroupQueryPreview : IEquatable<DynamicGroupQueryPreview>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicGroupQueryPreview" /> class.
    /// </summary>
    /// <param name="UserCount">Number of Users that match the DynamicGroupQuery.</param>
    public DynamicGroupQueryPreview(int? UserCount = null)
    {
        this.UserCount = UserCount;

    }



    /// <summary>
    /// Number of Users that match the DynamicGroupQuery
    /// </summary>
    /// <value>Number of Users that match the DynamicGroupQuery</value>
    [JsonPropertyName("userCount")]
    public int? UserCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicGroupQueryPreview {\n");

        sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
        return Equals(obj as DynamicGroupQueryPreview);
    }

    /// <summary>
    /// Returns true if DynamicGroupQueryPreview instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicGroupQueryPreview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicGroupQueryPreview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserCount == other.UserCount ||
                UserCount != null &&
                UserCount.Equals(other.UserCount)
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
            if (UserCount != null)
            {
                hash = hash * 59 + UserCount.GetHashCode();
            }

            return hash;
        }
    }
}
