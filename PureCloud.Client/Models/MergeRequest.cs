using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MergeRequest
/// </summary>

public partial class MergeRequest : IEquatable<MergeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MergeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MergeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MergeRequest" /> class.
    /// </summary>
    /// <param name="SourceContactId">The ID of the source contact for the merge operation (required).</param>
    /// <param name="TargetContactId">The ID of the target contact for the merge operation (required).</param>
    public MergeRequest(string SourceContactId = null, string TargetContactId = null)
    {
        this.SourceContactId = SourceContactId;
        this.TargetContactId = TargetContactId;

    }



    /// <summary>
    /// The ID of the source contact for the merge operation
    /// </summary>
    /// <value>The ID of the source contact for the merge operation</value>
    [JsonPropertyName("sourceContactId")]
    public string SourceContactId { get; set; }



    /// <summary>
    /// The ID of the target contact for the merge operation
    /// </summary>
    /// <value>The ID of the target contact for the merge operation</value>
    [JsonPropertyName("targetContactId")]
    public string TargetContactId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MergeRequest {\n");

        sb.Append("  SourceContactId: ").Append(SourceContactId).Append("\n");
        sb.Append("  TargetContactId: ").Append(TargetContactId).Append("\n");
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
        return Equals(obj as MergeRequest);
    }

    /// <summary>
    /// Returns true if MergeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MergeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MergeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceContactId == other.SourceContactId ||
                SourceContactId != null &&
                SourceContactId.Equals(other.SourceContactId)
            ) &&
            (
                TargetContactId == other.TargetContactId ||
                TargetContactId != null &&
                TargetContactId.Equals(other.TargetContactId)
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
            if (SourceContactId != null)
            {
                hash = hash * 59 + SourceContactId.GetHashCode();
            }

            if (TargetContactId != null)
            {
                hash = hash * 59 + TargetContactId.GetHashCode();
            }

            return hash;
        }
    }
}
