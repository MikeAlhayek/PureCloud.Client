using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentSchedulesQueryResponse
/// </summary>
[DataContract]
public partial class BuAgentSchedulesQueryResponse : IEquatable<BuAgentSchedulesQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentSchedulesQueryResponse" /> class.
    /// </summary>
    /// <param name="AgentSchedules">The requested agent schedules.</param>
    /// <param name="BusinessUnitTimeZone">The time zone configured for the business unit to which these schedules apply.</param>
    public BuAgentSchedulesQueryResponse(List<BuAgentScheduleQueryResponse> AgentSchedules = null, string BusinessUnitTimeZone = null)
    {
        this.AgentSchedules = AgentSchedules;
        this.BusinessUnitTimeZone = BusinessUnitTimeZone;

    }



    /// <summary>
    /// The requested agent schedules
    /// </summary>
    /// <value>The requested agent schedules</value>
    [DataMember(Name = "agentSchedules", EmitDefaultValue = false)]
    public List<BuAgentScheduleQueryResponse> AgentSchedules { get; set; }



    /// <summary>
    /// The time zone configured for the business unit to which these schedules apply
    /// </summary>
    /// <value>The time zone configured for the business unit to which these schedules apply</value>
    [DataMember(Name = "businessUnitTimeZone", EmitDefaultValue = false)]
    public string BusinessUnitTimeZone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentSchedulesQueryResponse {\n");

        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
        sb.Append("  BusinessUnitTimeZone: ").Append(BusinessUnitTimeZone).Append("\n");
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
        return Equals(obj as BuAgentSchedulesQueryResponse);
    }

    /// <summary>
    /// Returns true if BuAgentSchedulesQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentSchedulesQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentSchedulesQueryResponse other)
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

            return hash;
        }
    }
}
