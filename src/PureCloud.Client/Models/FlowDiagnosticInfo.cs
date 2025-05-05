using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowDiagnosticInfo
/// </summary>

public partial class FlowDiagnosticInfo : IEquatable<FlowDiagnosticInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowDiagnosticInfo" /> class.
    /// </summary>
    /// <param name="LastActionId">The step number of the survey invite flow where the error occurred..</param>
    public FlowDiagnosticInfo(int? LastActionId = null)
    {
        this.LastActionId = LastActionId;

    }



    /// <summary>
    /// The step number of the survey invite flow where the error occurred.
    /// </summary>
    /// <value>The step number of the survey invite flow where the error occurred.</value>
    [JsonPropertyName("lastActionId")]
    public int? LastActionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowDiagnosticInfo {\n");

        sb.Append("  LastActionId: ").Append(LastActionId).Append("\n");
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
        return Equals(obj as FlowDiagnosticInfo);
    }

    /// <summary>
    /// Returns true if FlowDiagnosticInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowDiagnosticInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowDiagnosticInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LastActionId == other.LastActionId ||
                LastActionId != null &&
                LastActionId.Equals(other.LastActionId)
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
            if (LastActionId != null)
            {
                hash = hash * 59 + LastActionId.GetHashCode();
            }

            return hash;
        }
    }
}
