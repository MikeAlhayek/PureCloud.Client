using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuCurrentAgentScheduleSearchResponse
/// </summary>
[DataContract]
public partial class BuCurrentAgentScheduleSearchResponse : IEquatable<BuCurrentAgentScheduleSearchResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuCurrentAgentScheduleSearchResponse" /> class.
    /// </summary>
    /// <param name="AgentSchedules">The requested agent schedules.</param>
    /// <param name="BusinessUnitTimeZone">The time zone configured for the business unit to which this schedule applies.</param>
    /// <param name="PublishedSchedules">References to all published week schedules overlapping the start/end date query parameters.</param>
    /// <param name="StartDate">The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Updates">The list of updates for the schedule. Only used in notifications.</param>
    public BuCurrentAgentScheduleSearchResponse(List<BuAgentScheduleSearchResponse> AgentSchedules = null, string BusinessUnitTimeZone = null, List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules = null, DateTime? StartDate = null, DateTime? EndDate = null, List<BuAgentScheduleUpdate> Updates = null)
    {
        this.AgentSchedules = AgentSchedules;
        this.BusinessUnitTimeZone = BusinessUnitTimeZone;
        this.PublishedSchedules = PublishedSchedules;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Updates = Updates;

    }



    /// <summary>
    /// The requested agent schedules
    /// </summary>
    /// <value>The requested agent schedules</value>
    [DataMember(Name = "agentSchedules", EmitDefaultValue = false)]
    public List<BuAgentScheduleSearchResponse> AgentSchedules { get; set; }



    /// <summary>
    /// The time zone configured for the business unit to which this schedule applies
    /// </summary>
    /// <value>The time zone configured for the business unit to which this schedule applies</value>
    [DataMember(Name = "businessUnitTimeZone", EmitDefaultValue = false)]
    public string BusinessUnitTimeZone { get; set; }



    /// <summary>
    /// References to all published week schedules overlapping the start/end date query parameters
    /// </summary>
    /// <value>References to all published week schedules overlapping the start/end date query parameters</value>
    [DataMember(Name = "publishedSchedules", EmitDefaultValue = false)]
    public List<BuAgentSchedulePublishedScheduleReference> PublishedSchedules { get; set; }



    /// <summary>
    /// The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the schedules. Only populated on notifications. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The list of updates for the schedule. Only used in notifications
    /// </summary>
    /// <value>The list of updates for the schedule. Only used in notifications</value>
    [DataMember(Name = "updates", EmitDefaultValue = false)]
    public List<BuAgentScheduleUpdate> Updates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuCurrentAgentScheduleSearchResponse {\n");

        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
        sb.Append("  BusinessUnitTimeZone: ").Append(BusinessUnitTimeZone).Append("\n");
        sb.Append("  PublishedSchedules: ").Append(PublishedSchedules).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  Updates: ").Append(Updates).Append("\n");
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
        return Equals(obj as BuCurrentAgentScheduleSearchResponse);
    }

    /// <summary>
    /// Returns true if BuCurrentAgentScheduleSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuCurrentAgentScheduleSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuCurrentAgentScheduleSearchResponse other)
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
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                Updates == other.Updates ||
                Updates != null &&
                Updates.SequenceEqual(other.Updates)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (Updates != null)
            {
                hash = hash * 59 + Updates.GetHashCode();
            }

            return hash;
        }
    }
}
