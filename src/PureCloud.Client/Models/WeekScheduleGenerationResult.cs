using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WeekScheduleGenerationResult
/// </summary>

public partial class WeekScheduleGenerationResult : IEquatable<WeekScheduleGenerationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WeekScheduleGenerationResult" /> class.
    /// </summary>
    /// <param name="Failed">Whether the schedule generation failed.</param>
    /// <param name="RunId">ID of the schedule run.</param>
    /// <param name="AgentWarnings">Warning messages from the schedule run. This will be available only when requesting information for a single week schedule.</param>
    /// <param name="AgentWarningCount">Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules.</param>
    public WeekScheduleGenerationResult(bool? Failed = null, string RunId = null, List<ScheduleGenerationWarning> AgentWarnings = null, int? AgentWarningCount = null)
    {
        this.Failed = Failed;
        this.RunId = RunId;
        this.AgentWarnings = AgentWarnings;
        this.AgentWarningCount = AgentWarningCount;

    }



    /// <summary>
    /// Whether the schedule generation failed
    /// </summary>
    /// <value>Whether the schedule generation failed</value>
    [JsonPropertyName("failed")]
    public bool? Failed { get; set; }



    /// <summary>
    /// ID of the schedule run
    /// </summary>
    /// <value>ID of the schedule run</value>
    [JsonPropertyName("runId")]
    public string RunId { get; set; }



    /// <summary>
    /// Warning messages from the schedule run. This will be available only when requesting information for a single week schedule
    /// </summary>
    /// <value>Warning messages from the schedule run. This will be available only when requesting information for a single week schedule</value>
    [JsonPropertyName("agentWarnings")]
    public List<ScheduleGenerationWarning> AgentWarnings { get; set; }



    /// <summary>
    /// Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules
    /// </summary>
    /// <value>Count of warning messages from the schedule run. This will be available only when requesting multiple week schedules</value>
    [JsonPropertyName("agentWarningCount")]
    public int? AgentWarningCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WeekScheduleGenerationResult {\n");

        sb.Append("  Failed: ").Append(Failed).Append("\n");
        sb.Append("  RunId: ").Append(RunId).Append("\n");
        sb.Append("  AgentWarnings: ").Append(AgentWarnings).Append("\n");
        sb.Append("  AgentWarningCount: ").Append(AgentWarningCount).Append("\n");
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
        return Equals(obj as WeekScheduleGenerationResult);
    }

    /// <summary>
    /// Returns true if WeekScheduleGenerationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of WeekScheduleGenerationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WeekScheduleGenerationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Failed == other.Failed ||
                Failed != null &&
                Failed.Equals(other.Failed)
            ) &&
            (
                RunId == other.RunId ||
                RunId != null &&
                RunId.Equals(other.RunId)
            ) &&
            (
                AgentWarnings == other.AgentWarnings ||
                AgentWarnings != null &&
                AgentWarnings.SequenceEqual(other.AgentWarnings)
            ) &&
            (
                AgentWarningCount == other.AgentWarningCount ||
                AgentWarningCount != null &&
                AgentWarningCount.Equals(other.AgentWarningCount)
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
            if (Failed != null)
            {
                hash = hash * 59 + Failed.GetHashCode();
            }

            if (RunId != null)
            {
                hash = hash * 59 + RunId.GetHashCode();
            }

            if (AgentWarnings != null)
            {
                hash = hash * 59 + AgentWarnings.GetHashCode();
            }

            if (AgentWarningCount != null)
            {
                hash = hash * 59 + AgentWarningCount.GetHashCode();
            }

            return hash;
        }
    }
}
