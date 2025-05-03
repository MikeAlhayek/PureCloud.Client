using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EndTransferEvent
/// </summary>

public partial class EndTransferEvent : IEquatable<EndTransferEvent>
{
    /// <summary>
    /// Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.
    /// </summary>
    /// <value>Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.</value>
    
    public enum FinalStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.
    /// </summary>
    /// <value>Indicates whether the transfer completed successfully, was cancelled, or failed for some reason.</value>
    [JsonPropertyName("finalState")]
    public FinalStateEnum? FinalState { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EndTransferEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EndTransferEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EndTransferEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommandId">The id (V4 UUID) used to identify the transfer already started by the external platform. (required).</param>
    /// <param name="FinalState">Indicates whether the transfer completed successfully, was cancelled, or failed for some reason. (required).</param>
    /// <param name="ObjectCommunicationId">The id (V4 UUID) of the communication that was being transferred. (required).</param>
    public EndTransferEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommandId = null, FinalStateEnum? FinalState = null, string ObjectCommunicationId = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommandId = CommandId;
        this.FinalState = FinalState;
        this.ObjectCommunicationId = ObjectCommunicationId;

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
    /// The id (V4 UUID) used to identify the transfer already started by the external platform.
    /// </summary>
    /// <value>The id (V4 UUID) used to identify the transfer already started by the external platform.</value>
    [JsonPropertyName("commandId")]
    public string CommandId { get; set; }





    /// <summary>
    /// The id (V4 UUID) of the communication that was being transferred.
    /// </summary>
    /// <value>The id (V4 UUID) of the communication that was being transferred.</value>
    [JsonPropertyName("objectCommunicationId")]
    public string ObjectCommunicationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EndTransferEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommandId: ").Append(CommandId).Append("\n");
        sb.Append("  FinalState: ").Append(FinalState).Append("\n");
        sb.Append("  ObjectCommunicationId: ").Append(ObjectCommunicationId).Append("\n");
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
        return Equals(obj as EndTransferEvent);
    }

    /// <summary>
    /// Returns true if EndTransferEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of EndTransferEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EndTransferEvent other)
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
                CommandId == other.CommandId ||
                CommandId != null &&
                CommandId.Equals(other.CommandId)
            ) &&
            (
                FinalState == other.FinalState ||
                FinalState != null &&
                FinalState.Equals(other.FinalState)
            ) &&
            (
                ObjectCommunicationId == other.ObjectCommunicationId ||
                ObjectCommunicationId != null &&
                ObjectCommunicationId.Equals(other.ObjectCommunicationId)
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

            if (CommandId != null)
            {
                hash = hash * 59 + CommandId.GetHashCode();
            }

            if (FinalState != null)
            {
                hash = hash * 59 + FinalState.GetHashCode();
            }

            if (ObjectCommunicationId != null)
            {
                hash = hash * 59 + ObjectCommunicationId.GetHashCode();
            }

            return hash;
        }
    }
}
