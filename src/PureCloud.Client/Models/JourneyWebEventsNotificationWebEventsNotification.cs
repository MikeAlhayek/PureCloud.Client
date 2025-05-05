using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebEventsNotificationWebEventsNotification
/// </summary>

public partial class JourneyWebEventsNotificationWebEventsNotification : IEquatable<JourneyWebEventsNotificationWebEventsNotification>
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    
    public enum EventTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Webevent for "WebEvent"
        /// </summary>
        [EnumMember(Value = "WebEvent")]
        Webevent,

        /// <summary>
        /// Enum Webactionevent for "WebActionEvent"
        /// </summary>
        [EnumMember(Value = "WebActionEvent")]
        Webactionevent,

        /// <summary>
        /// Enum Outcomeachievedevent for "OutcomeAchievedEvent"
        /// </summary>
        [EnumMember(Value = "OutcomeAchievedEvent")]
        Outcomeachievedevent,

        /// <summary>
        /// Enum Segmentassignmentevent for "SegmentAssignmentEvent"
        /// </summary>
        [EnumMember(Value = "SegmentAssignmentEvent")]
        Segmentassignmentevent
    }
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [JsonPropertyName("eventType")]
    public EventTypeEnum? EventType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationWebEventsNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="ExternalContact">ExternalContact.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="CustomerId">CustomerId.</param>
    /// <param name="CustomerIdType">CustomerIdType.</param>
    /// <param name="Session">Session.</param>
    /// <param name="EventType">EventType.</param>
    /// <param name="WebEvent">WebEvent.</param>
    /// <param name="WebActionEvent">WebActionEvent.</param>
    /// <param name="OutcomeAchievedEvent">OutcomeAchievedEvent.</param>
    /// <param name="SegmentAssignmentEvent">SegmentAssignmentEvent.</param>
    public JourneyWebEventsNotificationWebEventsNotification(string Id = null, string CorrelationId = null, JourneyWebEventsNotificationExternalContact ExternalContact = null, DateTime? CreatedDate = null, string CustomerId = null, string CustomerIdType = null, JourneyWebEventsNotificationSession Session = null, EventTypeEnum? EventType = null, JourneyWebEventsNotificationWebMessage WebEvent = null, JourneyWebEventsNotificationWebActionMessage WebActionEvent = null, JourneyWebEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent = null, JourneyWebEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent = null)
    {
        this.Id = Id;
        this.CorrelationId = CorrelationId;
        this.ExternalContact = ExternalContact;
        this.CreatedDate = CreatedDate;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.Session = Session;
        this.EventType = EventType;
        this.WebEvent = WebEvent;
        this.WebActionEvent = WebActionEvent;
        this.OutcomeAchievedEvent = OutcomeAchievedEvent;
        this.SegmentAssignmentEvent = SegmentAssignmentEvent;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    [JsonPropertyName("externalContact")]
    public JourneyWebEventsNotificationExternalContact ExternalContact { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// Gets or Sets CustomerIdType
    /// </summary>
    [JsonPropertyName("customerIdType")]
    public string CustomerIdType { get; set; }



    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    [JsonPropertyName("session")]
    public JourneyWebEventsNotificationSession Session { get; set; }





    /// <summary>
    /// Gets or Sets WebEvent
    /// </summary>
    [JsonPropertyName("webEvent")]
    public JourneyWebEventsNotificationWebMessage WebEvent { get; set; }



    /// <summary>
    /// Gets or Sets WebActionEvent
    /// </summary>
    [JsonPropertyName("webActionEvent")]
    public JourneyWebEventsNotificationWebActionMessage WebActionEvent { get; set; }



    /// <summary>
    /// Gets or Sets OutcomeAchievedEvent
    /// </summary>
    [JsonPropertyName("outcomeAchievedEvent")]
    public JourneyWebEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }



    /// <summary>
    /// Gets or Sets SegmentAssignmentEvent
    /// </summary>
    [JsonPropertyName("segmentAssignmentEvent")]
    public JourneyWebEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationWebEventsNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  Session: ").Append(Session).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  WebEvent: ").Append(WebEvent).Append("\n");
        sb.Append("  WebActionEvent: ").Append(WebActionEvent).Append("\n");
        sb.Append("  OutcomeAchievedEvent: ").Append(OutcomeAchievedEvent).Append("\n");
        sb.Append("  SegmentAssignmentEvent: ").Append(SegmentAssignmentEvent).Append("\n");
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
        return Equals(obj as JourneyWebEventsNotificationWebEventsNotification);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationWebEventsNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationWebEventsNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationWebEventsNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                CustomerId == other.CustomerId ||
                CustomerId != null &&
                CustomerId.Equals(other.CustomerId)
            ) &&
            (
                CustomerIdType == other.CustomerIdType ||
                CustomerIdType != null &&
                CustomerIdType.Equals(other.CustomerIdType)
            ) &&
            (
                Session == other.Session ||
                Session != null &&
                Session.Equals(other.Session)
            ) &&
            (
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
            ) &&
            (
                WebEvent == other.WebEvent ||
                WebEvent != null &&
                WebEvent.Equals(other.WebEvent)
            ) &&
            (
                WebActionEvent == other.WebActionEvent ||
                WebActionEvent != null &&
                WebActionEvent.Equals(other.WebActionEvent)
            ) &&
            (
                OutcomeAchievedEvent == other.OutcomeAchievedEvent ||
                OutcomeAchievedEvent != null &&
                OutcomeAchievedEvent.Equals(other.OutcomeAchievedEvent)
            ) &&
            (
                SegmentAssignmentEvent == other.SegmentAssignmentEvent ||
                SegmentAssignmentEvent != null &&
                SegmentAssignmentEvent.Equals(other.SegmentAssignmentEvent)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (CustomerId != null)
            {
                hash = hash * 59 + CustomerId.GetHashCode();
            }

            if (CustomerIdType != null)
            {
                hash = hash * 59 + CustomerIdType.GetHashCode();
            }

            if (Session != null)
            {
                hash = hash * 59 + Session.GetHashCode();
            }

            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            if (WebEvent != null)
            {
                hash = hash * 59 + WebEvent.GetHashCode();
            }

            if (WebActionEvent != null)
            {
                hash = hash * 59 + WebActionEvent.GetHashCode();
            }

            if (OutcomeAchievedEvent != null)
            {
                hash = hash * 59 + OutcomeAchievedEvent.GetHashCode();
            }

            if (SegmentAssignmentEvent != null)
            {
                hash = hash * 59 + SegmentAssignmentEvent.GetHashCode();
            }

            return hash;
        }
    }
}
