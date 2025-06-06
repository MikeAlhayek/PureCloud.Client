using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsChangeWorkitemDelta
/// </summary>

public partial class WorkitemsChangeWorkitemDelta : IEquatable<WorkitemsChangeWorkitemDelta>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsChangeWorkitemDelta" /> class.
    /// </summary>
    /// <param name="Version">Version.</param>
    /// <param name="ModifiedBy">modifiedBy.</param>
    /// <param name="Delta">The changes that originated this version.</param>
    public WorkitemsChangeWorkitemDelta(int? Version = null, UserReference ModifiedBy = null, WorkitemDelta Delta = null)
    {
        this.Version = Version;
        this.ModifiedBy = ModifiedBy;
        this.Delta = Delta;

    }



    /// <summary>
    /// Version
    /// </summary>
    /// <value>Version</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// modifiedBy
    /// </summary>
    /// <value>modifiedBy</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The changes that originated this version
    /// </summary>
    /// <value>The changes that originated this version</value>
    [JsonPropertyName("delta")]
    public WorkitemDelta Delta { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsChangeWorkitemDelta {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Delta: ").Append(Delta).Append("\n");
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
        return Equals(obj as WorkitemsChangeWorkitemDelta);
    }

    /// <summary>
    /// Returns true if WorkitemsChangeWorkitemDelta instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsChangeWorkitemDelta to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsChangeWorkitemDelta other)
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
                Delta == other.Delta ||
                Delta != null &&
                Delta.Equals(other.Delta)
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

            if (Delta != null)
            {
                hash = hash * 59 + Delta.GetHashCode();
            }

            return hash;
        }
    }
}
