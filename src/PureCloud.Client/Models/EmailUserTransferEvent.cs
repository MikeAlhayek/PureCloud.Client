using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailUserTransferEvent
/// </summary>

public partial class EmailUserTransferEvent : IEquatable<EmailUserTransferEvent>
{
    /// <summary>
    /// Indicates the desired type of transfer.
    /// </summary>
    /// <value>Indicates the desired type of transfer.</value>
    
    public enum TransferTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attended for "Attended"
        /// </summary>
        [EnumMember(Value = "Attended")]
        Attended,

        /// <summary>
        /// Enum Unattended for "Unattended"
        /// </summary>
        [EnumMember(Value = "Unattended")]
        Unattended
    }
    /// <summary>
    /// Indicates the desired type of transfer.
    /// </summary>
    /// <value>Indicates the desired type of transfer.</value>
    [JsonPropertyName("transferType")]
    public TransferTypeEnum? TransferType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailUserTransferEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmailUserTransferEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailUserTransferEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="TransferType">Indicates the desired type of transfer. (required).</param>
    /// <param name="CommandId">The id (V4 UUID) used by the external platform to refer to the transfer in subsequent Transfer events. (required).</param>
    /// <param name="InitiatingCommunicationId">The id (V4 UUID) of the communication representing the participant that is initiating the transfer. (required).</param>
    /// <param name="TargetCommunicationId">The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;. (required).</param>
    /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that is being transferred. (required).</param>
    /// <param name="DestinationUserId">The id (V4 UUID) of the desired destination user that the object communication should be transferred to. (required).</param>
    public EmailUserTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, TransferTypeEnum? TransferType = null, string CommandId = null, string InitiatingCommunicationId = null, string TargetCommunicationId = null, string ObjectCommunicationId = null, string DestinationUserId = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.TransferType = TransferType;
        this.CommandId = CommandId;
        this.InitiatingCommunicationId = InitiatingCommunicationId;
        this.TargetCommunicationId = TargetCommunicationId;
        this.ObjectCommunicationId = ObjectCommunicationId;
        this.DestinationUserId = DestinationUserId;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [JsonPropertyName("eventId")]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventDateTime")]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }





    /// <summary>
    /// The id (V4 UUID) used by the external platform to refer to the transfer in subsequent Transfer events.
    /// </summary>
    /// <value>The id (V4 UUID) used by the external platform to refer to the transfer in subsequent Transfer events.</value>
    [JsonPropertyName("commandId")]
    public string CommandId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication representing the participant that is initiating the transfer.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication representing the participant that is initiating the transfer.</value>
    [JsonPropertyName("initiatingCommunicationId")]
    public string InitiatingCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred away from. In many cases this will be the same as the &#x60;initiatingCommunicationId&#x60;.</value>
    [JsonPropertyName("targetCommunicationId")]
    public string TargetCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the communication that is being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that is being transferred.</value>
    [JsonPropertyName("objectCommunicationId")]
    public string ObjectCommunicationId { get; set; }



    /// <summary>
    /// The id (V4 UUID) of the desired destination user that the object communication should be transferred to.
    /// </summary>
    /// <value>The id (V4 UUID) of the desired destination user that the object communication should be transferred to.</value>
    [JsonPropertyName("destinationUserId")]
    public string DestinationUserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailUserTransferEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
        sb.Append("  CommandId: ").Append(CommandId).Append("\n");
        sb.Append("  InitiatingCommunicationId: ").Append(InitiatingCommunicationId).Append("\n");
        sb.Append("  TargetCommunicationId: ").Append(TargetCommunicationId).Append("\n");
        sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
        sb.Append("  DestinationUserId: ").Append(DestinationUserId).Append("\n");
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
        return Equals(obj as EmailUserTransferEvent);
    }

    /// <summary>
    /// Returns true if EmailUserTransferEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailUserTransferEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailUserTransferEvent other)
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
                TransferType == other.TransferType ||
                TransferType != null &&
                TransferType.Equals(other.TransferType)
            ) &&
            (
                CommandId == other.CommandId ||
                CommandId != null &&
                CommandId.Equals(other.CommandId)
            ) &&
            (
                InitiatingCommunicationId == other.InitiatingCommunicationId ||
                InitiatingCommunicationId != null &&
                InitiatingCommunicationId.Equals(other.InitiatingCommunicationId)
            ) &&
            (
                TargetCommunicationId == other.TargetCommunicationId ||
                TargetCommunicationId != null &&
                TargetCommunicationId.Equals(other.TargetCommunicationId)
            ) &&
            (
                ObjectCommunicationId == other.ObjectCommunicationId ||
                ObjectCommunicationId != null &&
                ObjectCommunicationId.Equals(other.ObjectCommunicationId)
            ) &&
            (
                DestinationUserId == other.DestinationUserId ||
                DestinationUserId != null &&
                DestinationUserId.Equals(other.DestinationUserId)
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

            if (TransferType != null)
            {
                hash = hash * 59 + TransferType.GetHashCode();
            }

            if (CommandId != null)
            {
                hash = hash * 59 + CommandId.GetHashCode();
            }

            if (InitiatingCommunicationId != null)
            {
                hash = hash * 59 + InitiatingCommunicationId.GetHashCode();
            }

            if (TargetCommunicationId != null)
            {
                hash = hash * 59 + TargetCommunicationId.GetHashCode();
            }

            if (ObjectCommunicationId != null)
            {
                hash = hash * 59 + ObjectCommunicationId.GetHashCode();
            }

            if (DestinationUserId != null)
            {
                hash = hash * 59 + DestinationUserId.GetHashCode();
            }

            return hash;
        }
    }
}
