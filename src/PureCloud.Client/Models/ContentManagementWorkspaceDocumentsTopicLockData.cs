using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentManagementWorkspaceDocumentsTopicLockData
/// </summary>

public partial class ContentManagementWorkspaceDocumentsTopicLockData : IEquatable<ContentManagementWorkspaceDocumentsTopicLockData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentManagementWorkspaceDocumentsTopicLockData" /> class.
    /// </summary>
    /// <param name="LockedBy">LockedBy.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="DateExpires">DateExpires.</param>
    public ContentManagementWorkspaceDocumentsTopicLockData(ContentManagementWorkspaceDocumentsTopicUserData LockedBy = null, DateTime? DateCreated = null, DateTime? DateExpires = null)
    {
        this.LockedBy = LockedBy;
        this.DateCreated = DateCreated;
        this.DateExpires = DateExpires;

    }



    /// <summary>
    /// Gets or Sets LockedBy
    /// </summary>
    [JsonPropertyName("lockedBy")]
    public ContentManagementWorkspaceDocumentsTopicUserData LockedBy { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    [JsonPropertyName("dateExpires")]
    public DateTime? DateExpires { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentManagementWorkspaceDocumentsTopicLockData {\n");

        sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
        return Equals(obj as ContentManagementWorkspaceDocumentsTopicLockData);
    }

    /// <summary>
    /// Returns true if ContentManagementWorkspaceDocumentsTopicLockData instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentManagementWorkspaceDocumentsTopicLockData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentManagementWorkspaceDocumentsTopicLockData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LockedBy == other.LockedBy ||
                LockedBy != null &&
                LockedBy.Equals(other.LockedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateExpires == other.DateExpires ||
                DateExpires != null &&
                DateExpires.Equals(other.DateExpires)
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
            if (LockedBy != null)
            {
                hash = hash * 59 + LockedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            return hash;
        }
    }
}
