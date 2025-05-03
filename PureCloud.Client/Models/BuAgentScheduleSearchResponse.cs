using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleSearchResponse
/// </summary>

public partial class BuAgentScheduleSearchResponse : IEquatable<BuAgentScheduleSearchResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleSearchResponse" /> class.
    /// </summary>
    /// <param name="User">The user to whom this agent schedule applies.</param>
    /// <param name="Shifts">The shift definitions for this agent schedule.</param>
    /// <param name="FullDayTimeOffMarkers">Full day time off markers which apply to this agent schedule.</param>
    public BuAgentScheduleSearchResponse(UserReference User = null, List<BuAgentScheduleShift> Shifts = null, List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers = null)
    {
        this.User = User;
        this.Shifts = Shifts;
        this.FullDayTimeOffMarkers = FullDayTimeOffMarkers;

    }



    /// <summary>
    /// The user to whom this agent schedule applies
    /// </summary>
    /// <value>The user to whom this agent schedule applies</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The shift definitions for this agent schedule
    /// </summary>
    /// <value>The shift definitions for this agent schedule</value>
    [JsonPropertyName("shifts")]
    public List<BuAgentScheduleShift> Shifts { get; set; }



    /// <summary>
    /// Full day time off markers which apply to this agent schedule
    /// </summary>
    /// <value>Full day time off markers which apply to this agent schedule</value>
    [JsonPropertyName("fullDayTimeOffMarkers")]
    public List<BuFullDayTimeOffMarker> FullDayTimeOffMarkers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleSearchResponse {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  FullDayTimeOffMarkers: ").Append(FullDayTimeOffMarkers).Append("\n");
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
        return Equals(obj as BuAgentScheduleSearchResponse);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleSearchResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Shifts == other.Shifts ||
                Shifts != null &&
                Shifts.SequenceEqual(other.Shifts)
            ) &&
            (
                FullDayTimeOffMarkers == other.FullDayTimeOffMarkers ||
                FullDayTimeOffMarkers != null &&
                FullDayTimeOffMarkers.SequenceEqual(other.FullDayTimeOffMarkers)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (FullDayTimeOffMarkers != null)
            {
                hash = hash * 59 + FullDayTimeOffMarkers.GetHashCode();
            }

            return hash;
        }
    }
}
