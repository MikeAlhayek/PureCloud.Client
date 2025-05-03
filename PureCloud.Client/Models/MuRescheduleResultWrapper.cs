using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MuRescheduleResultWrapper
/// </summary>

public partial class MuRescheduleResultWrapper : IEquatable<MuRescheduleResultWrapper>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MuRescheduleResultWrapper" /> class.
    /// </summary>
    /// <param name="AgentSchedules">The list of agent schedules.</param>
    public MuRescheduleResultWrapper(List<BuAgentScheduleRescheduleResponse> AgentSchedules = null)
    {
        this.AgentSchedules = AgentSchedules;

    }



    /// <summary>
    /// The list of agent schedules
    /// </summary>
    /// <value>The list of agent schedules</value>
    [JsonPropertyName("agentSchedules")]
    public List<BuAgentScheduleRescheduleResponse> AgentSchedules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MuRescheduleResultWrapper {\n");

        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
        return Equals(obj as MuRescheduleResultWrapper);
    }

    /// <summary>
    /// Returns true if MuRescheduleResultWrapper instances are equal
    /// </summary>
    /// <param name="other">Instance of MuRescheduleResultWrapper to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MuRescheduleResultWrapper other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentSchedules == other.AgentSchedules ||
                AgentSchedules != null &&
                AgentSchedules.SequenceEqual(other.AgentSchedules)
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
            if (AgentSchedules != null)
            {
                hash = hash * 59 + AgentSchedules.GetHashCode();
            }

            return hash;
        }
    }
}
