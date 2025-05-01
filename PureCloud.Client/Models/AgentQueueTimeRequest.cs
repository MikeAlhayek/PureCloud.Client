using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentQueueTimeRequest
/// </summary>
[DataContract]
public partial class AgentQueueTimeRequest : IEquatable<AgentQueueTimeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentQueueTimeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentQueueTimeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentQueueTimeRequest" /> class.
    /// </summary>
    /// <param name="AgentId">ID of the agent (required).</param>
    /// <param name="StartOffsetMinutes">List of offsets in minutes from calculationStartDate (required).</param>
    /// <param name="OnQueueLengthMinutesPerInterval">List of on queue time lengths in minutes per interval of elements in startOffsetMinutes (required).</param>
    public AgentQueueTimeRequest(string AgentId = null, List<int?> StartOffsetMinutes = null, List<int?> OnQueueLengthMinutesPerInterval = null)
    {
        this.AgentId = AgentId;
        this.StartOffsetMinutes = StartOffsetMinutes;
        this.OnQueueLengthMinutesPerInterval = OnQueueLengthMinutesPerInterval;

    }



    /// <summary>
    /// ID of the agent
    /// </summary>
    /// <value>ID of the agent</value>
    [DataMember(Name = "agentId", EmitDefaultValue = false)]
    public string AgentId { get; set; }



    /// <summary>
    /// List of offsets in minutes from calculationStartDate
    /// </summary>
    /// <value>List of offsets in minutes from calculationStartDate</value>
    [DataMember(Name = "startOffsetMinutes", EmitDefaultValue = false)]
    public List<int?> StartOffsetMinutes { get; set; }



    /// <summary>
    /// List of on queue time lengths in minutes per interval of elements in startOffsetMinutes
    /// </summary>
    /// <value>List of on queue time lengths in minutes per interval of elements in startOffsetMinutes</value>
    [DataMember(Name = "onQueueLengthMinutesPerInterval", EmitDefaultValue = false)]
    public List<int?> OnQueueLengthMinutesPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentQueueTimeRequest {\n");

        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  StartOffsetMinutes: ").Append(StartOffsetMinutes).Append("\n");
        sb.Append("  OnQueueLengthMinutesPerInterval: ").Append(OnQueueLengthMinutesPerInterval).Append("\n");
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
        return Equals(obj as AgentQueueTimeRequest);
    }

    /// <summary>
    /// Returns true if AgentQueueTimeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentQueueTimeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentQueueTimeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                StartOffsetMinutes == other.StartOffsetMinutes ||
                StartOffsetMinutes != null &&
                StartOffsetMinutes.SequenceEqual(other.StartOffsetMinutes)
            ) &&
            (
                OnQueueLengthMinutesPerInterval == other.OnQueueLengthMinutesPerInterval ||
                OnQueueLengthMinutesPerInterval != null &&
                OnQueueLengthMinutesPerInterval.SequenceEqual(other.OnQueueLengthMinutesPerInterval)
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
            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (StartOffsetMinutes != null)
            {
                hash = hash * 59 + StartOffsetMinutes.GetHashCode();
            }

            if (OnQueueLengthMinutesPerInterval != null)
            {
                hash = hash * 59 + OnQueueLengthMinutesPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
