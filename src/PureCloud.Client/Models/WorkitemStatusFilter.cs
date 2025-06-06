using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemStatusFilter
/// </summary>

public partial class WorkitemStatusFilter : IEquatable<WorkitemStatusFilter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemStatusFilter" /> class.
    /// </summary>
    /// <param name="WorktypeId">Worktype ID belonging to the selected workitem status.</param>
    /// <param name="WorkitemStatusId">Workitem status ID.</param>
    public WorkitemStatusFilter(string WorktypeId = null, string WorkitemStatusId = null)
    {
        this.WorktypeId = WorktypeId;
        this.WorkitemStatusId = WorkitemStatusId;

    }



    /// <summary>
    /// Worktype ID belonging to the selected workitem status
    /// </summary>
    /// <value>Worktype ID belonging to the selected workitem status</value>
    [JsonPropertyName("worktypeId")]
    public string WorktypeId { get; set; }



    /// <summary>
    /// Workitem status ID
    /// </summary>
    /// <value>Workitem status ID</value>
    [JsonPropertyName("workitemStatusId")]
    public string WorkitemStatusId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemStatusFilter {\n");

        sb.Append("  WorktypeId: ").Append(WorktypeId).Append("\n");
        sb.Append("  WorkitemStatusId: ").Append(WorkitemStatusId).Append("\n");
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
        return Equals(obj as WorkitemStatusFilter);
    }

    /// <summary>
    /// Returns true if WorkitemStatusFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemStatusFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemStatusFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorktypeId == other.WorktypeId ||
                WorktypeId != null &&
                WorktypeId.Equals(other.WorktypeId)
            ) &&
            (
                WorkitemStatusId == other.WorkitemStatusId ||
                WorkitemStatusId != null &&
                WorkitemStatusId.Equals(other.WorkitemStatusId)
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
            if (WorktypeId != null)
            {
                hash = hash * 59 + WorktypeId.GetHashCode();
            }

            if (WorkitemStatusId != null)
            {
                hash = hash * 59 + WorkitemStatusId.GetHashCode();
            }

            return hash;
        }
    }
}
