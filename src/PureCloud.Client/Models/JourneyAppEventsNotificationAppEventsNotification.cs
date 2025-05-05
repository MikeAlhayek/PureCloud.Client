using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationAppEventsNotification
/// </summary>

public partial class JourneyAppEventsNotificationAppEventsNotification : IEquatable<JourneyAppEventsNotificationAppEventsNotification>
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
        /// Enum Appevent for "AppEvent"
        /// </summary>
        [EnumMember(Value = "AppEvent")]
        Appevent,

        /// <summary>
        /// Enum Outcomeachievedevent for "OutcomeAchievedEvent"
        /// </summary>
        [EnumMember(Value = "OutcomeAchievedEvent")]
        Outcomeachievedevent,

        /// <summary>
        /// Enum Segmentassignmentevent for "SegmentAssignmentEvent"
        /// </summary>
        [EnumMember(Value = "SegmentAssignmentEvent")]
        Segmentassignmentevent,

        /// <summary>
        /// Enum Webactionevent for "WebActionEvent"
        /// </summary>
        [EnumMember(Value = "WebActionEvent")]
        Webactionevent
    }
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [JsonPropertyName("eventType")]
    public EventTypeEnum? EventType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationAppEventsNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="ExternalContact">ExternalContact.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="CustomerId">CustomerId.</param>
    /// <param name="CustomerIdType">CustomerIdType.</param>
    /// <param name="Session">Session.</param>
    /// <param name="EventType">EventType.</param>
    /// <param name="AppEvent">AppEvent.</param>
    /// <param name="OutcomeAchievedEvent">OutcomeAchievedEvent.</param>
    /// <param name="SegmentAssignmentEvent">SegmentAssignmentEvent.</param>
    /// <param name="WebActionEvent">WebActionEvent.</param>
    public JourneyAppEventsNotificationAppEventsNotification(string Id = null, string CorrelationId = null, JourneyAppEventsNotificationExternalContact ExternalContact = null, DateTime? CreatedDate = null, string CustomerId = null, string CustomerIdType = null, JourneyAppEventsNotificationSession Session = null, EventTypeEnum? EventType = null, JourneyAppEventsNotificationAppMessage AppEvent = null, JourneyAppEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent = null, JourneyAppEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent = null, JourneyAppEventsNotificationWebActionMessage WebActionEvent = null)
    {
        this.Id = Id;
        this.CorrelationId = CorrelationId;
        this.ExternalContact = ExternalContact;
        this.CreatedDate = CreatedDate;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.Session = Session;
        this.EventType = EventType;
        this.AppEvent = AppEvent;
        this.OutcomeAchievedEvent = OutcomeAchievedEvent;
        this.SegmentAssignmentEvent = SegmentAssignmentEvent;
        this.WebActionEvent = WebActionEvent;

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
    public JourneyAppEventsNotificationExternalContact ExternalContact { get; set; }



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
    public JourneyAppEventsNotificationSession Session { get; set; }





    /// <summary>
    /// Gets or Sets AppEvent
    /// </summary>
    [JsonPropertyName("appEvent")]
    public JourneyAppEventsNotificationAppMessage AppEvent { get; set; }



    /// <summary>
    /// Gets or Sets OutcomeAchievedEvent
    /// </summary>
    [JsonPropertyName("outcomeAchievedEvent")]
    public JourneyAppEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }



    /// <summary>
    /// Gets or Sets SegmentAssignmentEvent
    /// </summary>
    [JsonPropertyName("segmentAssignmentEvent")]
    public JourneyAppEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent { get; set; }



    /// <summary>
    /// Gets or Sets WebActionEvent
    /// </summary>
    [JsonPropertyName("webActionEvent")]
    public JourneyAppEventsNotificationWebActionMessage WebActionEvent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationAppEventsNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  Session: ").Append(Session).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  AppEvent: ").Append(AppEvent).Append("\n");
        sb.Append("  OutcomeAchievedEvent: ").Append(OutcomeAchievedEvent).Append("\n");
        sb.Append("  SegmentAssignmentEvent: ").Append(SegmentAssignmentEvent).Append("\n");
        sb.Append("  WebActionEvent: ").Append(WebActionEvent).Append("\n");
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
        return Equals(obj as JourneyAppEventsNotificationAppEventsNotification);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationAppEventsNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationAppEventsNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationAppEventsNotification other)
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
                AppEvent == other.AppEvent ||
                AppEvent != null &&
                AppEvent.Equals(other.AppEvent)
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
            ) &&
            (
                WebActionEvent == other.WebActionEvent ||
                WebActionEvent != null &&
                WebActionEvent.Equals(other.WebActionEvent)
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

            if (AppEvent != null)
            {
                hash = hash * 59 + AppEvent.GetHashCode();
            }

            if (OutcomeAchievedEvent != null)
            {
                hash = hash * 59 + OutcomeAchievedEvent.GetHashCode();
            }

            if (SegmentAssignmentEvent != null)
            {
                hash = hash * 59 + SegmentAssignmentEvent.GetHashCode();
            }

            if (WebActionEvent != null)
            {
                hash = hash * 59 + WebActionEvent.GetHashCode();
            }

            return hash;
        }
    }
}
