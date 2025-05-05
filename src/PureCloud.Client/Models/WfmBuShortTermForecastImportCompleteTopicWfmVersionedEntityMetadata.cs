using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata
/// </summary>

public partial class WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata : IEquatable<WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata" /> class.
    /// </summary>
    /// <param name="Version">Version.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">DateModified.</param>
    public WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata(long? Version = null, WfmBuShortTermForecastImportCompleteTopicUserReference ModifiedBy = null, DateTime? DateModified = null)
    {
        this.Version = Version;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public long? Version { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public WfmBuShortTermForecastImportCompleteTopicUserReference ModifiedBy { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata other)
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

            return hash;
        }
    }
}
