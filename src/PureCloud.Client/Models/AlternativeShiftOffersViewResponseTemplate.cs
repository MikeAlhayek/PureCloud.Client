using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftOffersViewResponseTemplate
/// </summary>

public partial class AlternativeShiftOffersViewResponseTemplate : IEquatable<AlternativeShiftOffersViewResponseTemplate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftOffersViewResponseTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftOffersViewResponseTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftOffersViewResponseTemplate" /> class.
    /// </summary>
    /// <param name="JobId">The unique identifier of the async list job that created this file (required).</param>
    /// <param name="BusinessUnitId">The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created (required).</param>
    /// <param name="AgentId">The unique identifier of the agent for whom the offer was made (required).</param>
    /// <param name="ManagementUnitId">The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created (required).</param>
    /// <param name="Schedule">The existing schedule information associated with the offer (required).</param>
    /// <param name="OfferWeekDate">The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Shifts">The shifts the agent is scheduled for at the time the offer is created (required).</param>
    /// <param name="AlternativeDays">The offered alternative shift days in this week at the time the offer is created (required).</param>
    public AlternativeShiftOffersViewResponseTemplate(string JobId = null, string BusinessUnitId = null, string AgentId = null, string ManagementUnitId = null, AlternativeShiftScheduleLookup Schedule = null, string OfferWeekDate = null, List<AlternativeShiftAgentScheduledShift> Shifts = null, List<AlternativeShiftAgentScheduledShift> AlternativeDays = null)
    {
        this.JobId = JobId;
        this.BusinessUnitId = BusinessUnitId;
        this.AgentId = AgentId;
        this.ManagementUnitId = ManagementUnitId;
        this.Schedule = Schedule;
        this.OfferWeekDate = OfferWeekDate;
        this.Shifts = Shifts;
        this.AlternativeDays = AlternativeDays;

    }



    /// <summary>
    /// The unique identifier of the async list job that created this file
    /// </summary>
    /// <value>The unique identifier of the async list job that created this file</value>
    [JsonPropertyName("jobId")]
    public string JobId { get; set; }



    /// <summary>
    /// The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created
    /// </summary>
    /// <value>The unique identifier of the business unit to which the user (agent) belongs at the time the offer is created</value>
    [JsonPropertyName("businessUnitId")]
    public string BusinessUnitId { get; set; }



    /// <summary>
    /// The unique identifier of the agent for whom the offer was made
    /// </summary>
    /// <value>The unique identifier of the agent for whom the offer was made</value>
    [JsonPropertyName("agentId")]
    public string AgentId { get; set; }



    /// <summary>
    /// The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created
    /// </summary>
    /// <value>The unique identifier of the management unit to which the user (agent) belongs at the time the offer is created</value>
    [JsonPropertyName("managementUnitId")]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// The existing schedule information associated with the offer
    /// </summary>
    /// <value>The existing schedule information associated with the offer</value>
    [JsonPropertyName("schedule")]
    public AlternativeShiftScheduleLookup Schedule { get; set; }



    /// <summary>
    /// The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The first date of the week for the schedule we are querying in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("offerWeekDate")]
    public string OfferWeekDate { get; set; }



    /// <summary>
    /// The shifts the agent is scheduled for at the time the offer is created
    /// </summary>
    /// <value>The shifts the agent is scheduled for at the time the offer is created</value>
    [JsonPropertyName("shifts")]
    public List<AlternativeShiftAgentScheduledShift> Shifts { get; set; }



    /// <summary>
    /// The offered alternative shift days in this week at the time the offer is created
    /// </summary>
    /// <value>The offered alternative shift days in this week at the time the offer is created</value>
    [JsonPropertyName("alternativeDays")]
    public List<AlternativeShiftAgentScheduledShift> AlternativeDays { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeShiftOffersViewResponseTemplate {\n");

        sb.Append("  JobId: ").Append(JobId).Append("\n");
        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  OfferWeekDate: ").Append(OfferWeekDate).Append("\n");
        sb.Append("  Shifts: ").Append(Shifts).Append("\n");
        sb.Append("  AlternativeDays: ").Append(AlternativeDays).Append("\n");
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
        return Equals(obj as AlternativeShiftOffersViewResponseTemplate);
    }

    /// <summary>
    /// Returns true if AlternativeShiftOffersViewResponseTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftOffersViewResponseTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftOffersViewResponseTemplate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JobId == other.JobId ||
                JobId != null &&
                JobId.Equals(other.JobId)
            ) &&
            (
                BusinessUnitId == other.BusinessUnitId ||
                BusinessUnitId != null &&
                BusinessUnitId.Equals(other.BusinessUnitId)
            ) &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                OfferWeekDate == other.OfferWeekDate ||
                OfferWeekDate != null &&
                OfferWeekDate.Equals(other.OfferWeekDate)
            ) &&
            (
                Shifts == other.Shifts ||
                Shifts != null &&
                Shifts.SequenceEqual(other.Shifts)
            ) &&
            (
                AlternativeDays == other.AlternativeDays ||
                AlternativeDays != null &&
                AlternativeDays.SequenceEqual(other.AlternativeDays)
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
            if (JobId != null)
            {
                hash = hash * 59 + JobId.GetHashCode();
            }

            if (BusinessUnitId != null)
            {
                hash = hash * 59 + BusinessUnitId.GetHashCode();
            }

            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (OfferWeekDate != null)
            {
                hash = hash * 59 + OfferWeekDate.GetHashCode();
            }

            if (Shifts != null)
            {
                hash = hash * 59 + Shifts.GetHashCode();
            }

            if (AlternativeDays != null)
            {
                hash = hash * 59 + AlternativeDays.GetHashCode();
            }

            return hash;
        }
    }
}
