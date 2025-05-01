using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MuAgentQueueTimeRequest
/// </summary>
[DataContract]
public partial class MuAgentQueueTimeRequest : IEquatable<MuAgentQueueTimeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MuAgentQueueTimeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MuAgentQueueTimeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MuAgentQueueTimeRequest" /> class.
    /// </summary>
    /// <param name="ManagementUnitId">ID of the management unit (required).</param>
    /// <param name="AgentOnQueueTimes">List of Agent queue times within the management unit (required).</param>
    public MuAgentQueueTimeRequest(string ManagementUnitId = null, List<AgentQueueTimeRequest> AgentOnQueueTimes = null)
    {
        this.ManagementUnitId = ManagementUnitId;
        this.AgentOnQueueTimes = AgentOnQueueTimes;

    }



    /// <summary>
    /// ID of the management unit
    /// </summary>
    /// <value>ID of the management unit</value>
    [DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
    public string ManagementUnitId { get; set; }



    /// <summary>
    /// List of Agent queue times within the management unit
    /// </summary>
    /// <value>List of Agent queue times within the management unit</value>
    [DataMember(Name = "agentOnQueueTimes", EmitDefaultValue = false)]
    public List<AgentQueueTimeRequest> AgentOnQueueTimes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MuAgentQueueTimeRequest {\n");

        sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
        sb.Append("  AgentOnQueueTimes: ").Append(AgentOnQueueTimes).Append("\n");
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
        return Equals(obj as MuAgentQueueTimeRequest);
    }

    /// <summary>
    /// Returns true if MuAgentQueueTimeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MuAgentQueueTimeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MuAgentQueueTimeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitId == other.ManagementUnitId ||
                ManagementUnitId != null &&
                ManagementUnitId.Equals(other.ManagementUnitId)
            ) &&
            (
                AgentOnQueueTimes == other.AgentOnQueueTimes ||
                AgentOnQueueTimes != null &&
                AgentOnQueueTimes.SequenceEqual(other.AgentOnQueueTimes)
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
            if (ManagementUnitId != null)
            {
                hash = hash * 59 + ManagementUnitId.GetHashCode();
            }

            if (AgentOnQueueTimes != null)
            {
                hash = hash * 59 + AgentOnQueueTimes.GetHashCode();
            }

            return hash;
        }
    }
}
