using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentSchedulesSearchResponse
/// </summary>

public partial class BuAgentSchedulesSearchResponse : IEquatable<BuAgentSchedulesSearchResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentSchedulesSearchResponse" /> class.
    /// </summary>
    /// <param name="AgentSchedules">The requested agent schedules.</param>
    /// <param name="BusinessUnitTimeZone">The time zone configured for the business unit to which this schedule applies.</param>
    /// <param name="PublishedSchedules">References to all published week schedules overlapping the start/end date query parameters.</param>
    public BuAgentSchedulesSearchResponse(List<BuAgentScheduleSearchResponse> AgentSchedules = null, string BusinessUnitTimeZone = null, List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules = null)
    {
        this.AgentSchedules = AgentSchedules;
        this.BusinessUnitTimeZone = BusinessUnitTimeZone;
        this.PublishedSchedules = PublishedSchedules;

    }



    /// <summary>
    /// The requested agent schedules
    /// </summary>
    /// <value>The requested agent schedules</value>
    [JsonPropertyName("agentSchedules")]
    public List<BuAgentScheduleSearchResponse> AgentSchedules { get; set; }



    /// <summary>
    /// The time zone configured for the business unit to which this schedule applies
    /// </summary>
    /// <value>The time zone configured for the business unit to which this schedule applies</value>
    [JsonPropertyName("businessUnitTimeZone")]
    public string BusinessUnitTimeZone { get; set; }



    /// <summary>
    /// References to all published week schedules overlapping the start/end date query parameters
    /// </summary>
    /// <value>References to all published week schedules overlapping the start/end date query parameters</value>
    [JsonPropertyName("publishedSchedules")]
    public List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentSchedulesSearchResponse {\n");

        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
        sb.Append("  BusinessUnitTimeZone: ").Append(BusinessUnitTimeZone).Append("\n");
        sb.Append("  PublishedSchedules: ").Append(PublishedSchedules).Append("\n");
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
        return Equals(obj as BuAgentSchedulesSearchResponse);
    }

    /// <summary>
    /// Returns true if BuAgentSchedulesSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentSchedulesSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentSchedulesSearchResponse other)
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
            ) &&
            (
                BusinessUnitTimeZone == other.BusinessUnitTimeZone ||
                BusinessUnitTimeZone != null &&
                BusinessUnitTimeZone.Equals(other.BusinessUnitTimeZone)
            ) &&
            (
                PublishedSchedules == other.PublishedSchedules ||
                PublishedSchedules != null &&
                PublishedSchedules.SequenceEqual(other.PublishedSchedules)
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

            if (BusinessUnitTimeZone != null)
            {
                hash = hash * 59 + BusinessUnitTimeZone.GetHashCode();
            }

            if (PublishedSchedules != null)
            {
                hash = hash * 59 + PublishedSchedules.GetHashCode();
            }

            return hash;
        }
    }
}
