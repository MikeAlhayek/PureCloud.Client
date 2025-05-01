using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserEstablishedEvent
/// </summary>
[DataContract]
public partial class UserEstablishedEvent : IEquatable<UserEstablishedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserEstablishedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserEstablishedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserEstablishedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
    /// <param name="PhoneNumber">Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId..</param>
    /// <param name="UserId">The userId (V4 UUID) for the user this communication belongs to. (required).</param>
    /// <param name="StationId">A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known..</param>
    /// <param name="Ani">The automatic number identification if it is available for this conversation..</param>
    /// <param name="Dnis">The dialed number identification if it is available for this conversation..</param>
    /// <param name="AfterCallWorkRequired">Indicates whether or not this user will be required to complete after call work..</param>
    /// <param name="QueueId">The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only..</param>
    /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
    /// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
    public UserEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string PhoneNumber = null, string UserId = null, string StationId = null, string Ani = null, string Dnis = null, bool? AfterCallWorkRequired = null, string QueueId = null, InitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.PhoneNumber = PhoneNumber;
        this.UserId = UserId;
        this.StationId = StationId;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.QueueId = QueueId;
        this.InitialConfiguration = InitialConfiguration;
        this.SourceConfiguration = SourceConfiguration;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [DataMember(Name = "eventId", EmitDefaultValue = false)]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    [DataMember(Name = "communicationId", EmitDefaultValue = false)]
    public string CommunicationId { get; set; }



    /// <summary>
    /// Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId.
    /// </summary>
    /// <value>Identifies the phone number used to reach this user if it is different from the information that would be accessed by userId.</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The userId (V4 UUID) for the user this communication belongs to.
    /// </summary>
    /// <value>The userId (V4 UUID) for the user this communication belongs to.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known.
    /// </summary>
    /// <value>A Station ID (V4 UUID) that identifies the station being used if the user is using a station and the stationId is known.</value>
    [DataMember(Name = "stationId", EmitDefaultValue = false)]
    public string StationId { get; set; }



    /// <summary>
    /// The automatic number identification if it is available for this conversation.
    /// </summary>
    /// <value>The automatic number identification if it is available for this conversation.</value>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// The dialed number identification if it is available for this conversation.
    /// </summary>
    /// <value>The dialed number identification if it is available for this conversation.</value>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }



    /// <summary>
    /// Indicates whether or not this user will be required to complete after call work.
    /// </summary>
    /// <value>Indicates whether or not this user will be required to complete after call work.</value>
    [DataMember(Name = "afterCallWorkRequired", EmitDefaultValue = false)]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only.
    /// </summary>
    /// <value>The id (V4 UUID) of the queue that the user is calling on behalf of. Applies to outbound calls only.</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    [DataMember(Name = "initialConfiguration", EmitDefaultValue = false)]
    public InitialConfiguration InitialConfiguration { get; set; }



    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    [DataMember(Name = "sourceConfiguration", EmitDefaultValue = false)]
    public SourceConfiguration SourceConfiguration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserEstablishedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  StationId: ").Append(StationId).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
        sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
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
        return Equals(obj as UserEstablishedEvent);
    }

    /// <summary>
    /// Returns true if UserEstablishedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of UserEstablishedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserEstablishedEvent other)
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
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                StationId == other.StationId ||
                StationId != null &&
                StationId.Equals(other.StationId)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                AfterCallWorkRequired == other.AfterCallWorkRequired ||
                AfterCallWorkRequired != null &&
                AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                InitialConfiguration == other.InitialConfiguration ||
                InitialConfiguration != null &&
                InitialConfiguration.Equals(other.InitialConfiguration)
            ) &&
            (
                SourceConfiguration == other.SourceConfiguration ||
                SourceConfiguration != null &&
                SourceConfiguration.Equals(other.SourceConfiguration)
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

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (StationId != null)
            {
                hash = hash * 59 + StationId.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (AfterCallWorkRequired != null)
            {
                hash = hash * 59 + AfterCallWorkRequired.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (InitialConfiguration != null)
            {
                hash = hash * 59 + InitialConfiguration.GetHashCode();
            }

            if (SourceConfiguration != null)
            {
                hash = hash * 59 + SourceConfiguration.GetHashCode();
            }

            return hash;
        }
    }
}
