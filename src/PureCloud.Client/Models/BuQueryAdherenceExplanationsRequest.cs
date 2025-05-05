using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuQueryAdherenceExplanationsRequest
/// </summary>

public partial class BuQueryAdherenceExplanationsRequest : IEquatable<BuQueryAdherenceExplanationsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuQueryAdherenceExplanationsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuQueryAdherenceExplanationsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuQueryAdherenceExplanationsRequest" /> class.
    /// </summary>
    /// <param name="StartDate">The start date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndDate">The end date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ManagementUnitIds">A filter for which management units to query. Leave empty or omit entirely for all management units in the business unit.</param>
    /// <param name="AgentIds">A filter for which agents within the business unit to query. Leave empty or omit entirely for all agents in the business unit (or management units if specified).</param>
    public BuQueryAdherenceExplanationsRequest(DateTime? StartDate = null, DateTime? EndDate = null, List<string> ManagementUnitIds = null, List<string> AgentIds = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.ManagementUnitIds = ManagementUnitIds;
        this.AgentIds = AgentIds;

    }



    /// <summary>
    /// The start date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the range to query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// A filter for which management units to query. Leave empty or omit entirely for all management units in the business unit
    /// </summary>
    /// <value>A filter for which management units to query. Leave empty or omit entirely for all management units in the business unit</value>
    [JsonPropertyName("managementUnitIds")]
    public List<string> ManagementUnitIds { get; set; }



    /// <summary>
    /// A filter for which agents within the business unit to query. Leave empty or omit entirely for all agents in the business unit (or management units if specified)
    /// </summary>
    /// <value>A filter for which agents within the business unit to query. Leave empty or omit entirely for all agents in the business unit (or management units if specified)</value>
    [JsonPropertyName("agentIds")]
    public List<string> AgentIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuQueryAdherenceExplanationsRequest {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
        sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
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
        return Equals(obj as BuQueryAdherenceExplanationsRequest);
    }

    /// <summary>
    /// Returns true if BuQueryAdherenceExplanationsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuQueryAdherenceExplanationsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuQueryAdherenceExplanationsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
            ) &&
            (
                AgentIds == other.AgentIds ||
                AgentIds != null &&
                AgentIds.SequenceEqual(other.AgentIds)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
            }

            if (AgentIds != null)
            {
                hash = hash * 59 + AgentIds.GetHashCode();
            }

            return hash;
        }
    }
}
