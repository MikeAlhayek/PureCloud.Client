using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserRoutingStatusEvent
/// </summary>

public partial class UserRoutingStatusEvent : IEquatable<UserRoutingStatusEvent>
{
    /// <summary>
    /// The agent's current routing status.
    /// </summary>
    /// <value>The agent's current routing status.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Offqueue for "OffQueue"
        /// </summary>
        [EnumMember(Value = "OffQueue")]
        Offqueue,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Interacting for "Interacting"
        /// </summary>
        [EnumMember(Value = "Interacting")]
        Interacting,

        /// <summary>
        /// Enum Communicating for "Communicating"
        /// </summary>
        [EnumMember(Value = "Communicating")]
        Communicating,

        /// <summary>
        /// Enum Notresponding for "NotResponding"
        /// </summary>
        [EnumMember(Value = "NotResponding")]
        Notresponding
    }
    /// <summary>
    /// The agent's current routing status.
    /// </summary>
    /// <value>The agent's current routing status.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingStatusEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserRoutingStatusEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRoutingStatusEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="AgentId">Unique identifier of the agent. (required).</param>
    /// <param name="Status">The agent&#39;s current routing status. (required).</param>
    /// <param name="SourceId">The agent&#39;s source platform Id. (required).</param>
    public UserRoutingStatusEvent(string EventId = null, DateTime? EventDateTime = null, string AgentId = null, StatusEnum? Status = null, string SourceId = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.AgentId = AgentId;
        this.Status = Status;
        this.SourceId = SourceId;

    }



    /// <summary>
    /// A unique (UUID) eventId for this event
    /// </summary>
    /// <value>A unique (UUID) eventId for this event</value>
    [JsonPropertyName("eventId")]
    public string EventId { get; set; }



    /// <summary>
    /// A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A timestamp as epoch representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventDateTime")]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// Unique identifier of the agent.
    /// </summary>
    /// <value>Unique identifier of the agent.</value>
    [JsonPropertyName("agentId")]
    public string AgentId { get; set; }





    /// <summary>
    /// The agent&#39;s source platform Id.
    /// </summary>
    /// <value>The agent&#39;s source platform Id.</value>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserRoutingStatusEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
        return Equals(obj as UserRoutingStatusEvent);
    }

    /// <summary>
    /// Returns true if UserRoutingStatusEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of UserRoutingStatusEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserRoutingStatusEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventId == other.EventId ||
                EventId != null &&
                EventId.Equals(other.EventId)
            ) &&
            (
                EventDateTime == other.EventDateTime ||
                EventDateTime != null &&
                EventDateTime.Equals(other.EventDateTime)
            ) &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
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
            if (EventId != null)
            {
                hash = hash * 59 + EventId.GetHashCode();
            }

            if (EventDateTime != null)
            {
                hash = hash * 59 + EventDateTime.GetHashCode();
            }

            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            return hash;
        }
    }
}
