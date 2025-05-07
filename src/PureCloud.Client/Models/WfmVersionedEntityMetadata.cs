using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmVersionedEntityMetadata
/// </summary>

public partial class WfmVersionedEntityMetadata : IEquatable<WfmVersionedEntityMetadata>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmVersionedEntityMetadata" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmVersionedEntityMetadata() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmVersionedEntityMetadata" /> class.
    /// </summary>
    /// <param name="Version">The version of the associated entity.  Used to prevent conflicts on concurrent edits (required).</param>
    public WfmVersionedEntityMetadata(int? Version = null)
    {
        this.Version = Version;

    }



    /// <summary>
    /// The version of the associated entity.  Used to prevent conflicts on concurrent edits
    /// </summary>
    /// <value>The version of the associated entity.  Used to prevent conflicts on concurrent edits</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The user who last modified the associated entity. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who last modified the associated entity. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The date the associated entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the associated entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The user who created the associated entity, if available. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who created the associated entity, if available. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date the associated entity was created, if available. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the associated entity was created, if available. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmVersionedEntityMetadata {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
        return Equals(obj as WfmVersionedEntityMetadata);
    }

    /// <summary>
    /// Returns true if WfmVersionedEntityMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmVersionedEntityMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmVersionedEntityMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            return hash;
        }
    }
}
