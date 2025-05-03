using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Event
/// </summary>

public partial class Event : IEquatable<Event>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Event() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Event" /> class.
    /// </summary>
    /// <param name="Id">System-generated UUID for the event. (required).</param>
    /// <param name="CorrelationId">UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event). (required).</param>
    /// <param name="CustomerId">Primary identifier of the customer in the source of the events..</param>
    /// <param name="CustomerIdType">Type of primary identifier (e.g. cookie, email, phone)..</param>
    /// <param name="Session">The session that the event belongs to. (required).</param>
    /// <param name="EventType">The name representing the type of event. (required).</param>
    /// <param name="OutcomeAchievedEvent">Event where a customer has achieved a specific outcome or goal..</param>
    /// <param name="SegmentAssignmentEvent">Event that represents a segment being assigned..</param>
    /// <param name="WebActionEvent">Event triggered by web actions..</param>
    /// <param name="WebEvent">Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc..</param>
    /// <param name="AppEvent">Event that tracks user interactions with content in an application such as screen views, searches, etc..</param>
    /// <param name="CreatedDate">Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public Event(string Id = null, string CorrelationId = null, string CustomerId = null, string CustomerIdType = null, EventSession Session = null, string EventType = null, OutcomeAchievedEvent OutcomeAchievedEvent = null, SegmentAssignmentEvent SegmentAssignmentEvent = null, WebActionEvent WebActionEvent = null, WebEvent WebEvent = null, AppEvent AppEvent = null, DateTime? CreatedDate = null)
    {
        this.Id = Id;
        this.CorrelationId = CorrelationId;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.Session = Session;
        this.EventType = EventType;
        this.OutcomeAchievedEvent = OutcomeAchievedEvent;
        this.SegmentAssignmentEvent = SegmentAssignmentEvent;
        this.WebActionEvent = WebActionEvent;
        this.WebEvent = WebEvent;
        this.AppEvent = AppEvent;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// System-generated UUID for the event.
    /// </summary>
    /// <value>System-generated UUID for the event.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event).
    /// </summary>
    /// <value>UUID corresponding to triggering action that caused this event (e.g. HTTP POST, SIP invite, another event).</value>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Primary identifier of the customer in the source of the events.
    /// </summary>
    /// <value>Primary identifier of the customer in the source of the events.</value>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// Type of primary identifier (e.g. cookie, email, phone).
    /// </summary>
    /// <value>Type of primary identifier (e.g. cookie, email, phone).</value>
    [JsonPropertyName("customerIdType")]
    public string CustomerIdType { get; set; }



    /// <summary>
    /// The session that the event belongs to.
    /// </summary>
    /// <value>The session that the event belongs to.</value>
    [JsonPropertyName("session")]
    public EventSession Session { get; set; }



    /// <summary>
    /// The name representing the type of event.
    /// </summary>
    /// <value>The name representing the type of event.</value>
    [JsonPropertyName("eventType")]
    public string EventType { get; set; }



    /// <summary>
    /// Event where a customer has achieved a specific outcome or goal.
    /// </summary>
    /// <value>Event where a customer has achieved a specific outcome or goal.</value>
    [JsonPropertyName("outcomeAchievedEvent")]
    public OutcomeAchievedEvent OutcomeAchievedEvent { get; set; }



    /// <summary>
    /// Event that represents a segment being assigned.
    /// </summary>
    /// <value>Event that represents a segment being assigned.</value>
    [JsonPropertyName("segmentAssignmentEvent")]
    public SegmentAssignmentEvent SegmentAssignmentEvent { get; set; }



    /// <summary>
    /// Event triggered by web actions.
    /// </summary>
    /// <value>Event triggered by web actions.</value>
    [JsonPropertyName("webActionEvent")]
    public WebActionEvent WebActionEvent { get; set; }



    /// <summary>
    /// Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc.
    /// </summary>
    /// <value>Event that tracks user interactions with content in a browser such as pageviews, downloads, mobile ad clicks, etc.</value>
    [JsonPropertyName("webEvent")]
    public WebEvent WebEvent { get; set; }



    /// <summary>
    /// Event that tracks user interactions with content in an application such as screen views, searches, etc.
    /// </summary>
    /// <value>Event that tracks user interactions with content in an application such as screen views, searches, etc.</value>
    [JsonPropertyName("appEvent")]
    public AppEvent AppEvent { get; set; }



    /// <summary>
    /// Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Event {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  Session: ").Append(Session).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  OutcomeAchievedEvent: ").Append(OutcomeAchievedEvent).Append("\n");
        sb.Append("  SegmentAssignmentEvent: ").Append(SegmentAssignmentEvent).Append("\n");
        sb.Append("  WebActionEvent: ").Append(WebActionEvent).Append("\n");
        sb.Append("  WebEvent: ").Append(WebEvent).Append("\n");
        sb.Append("  AppEvent: ").Append(AppEvent).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as Event);
    }

    /// <summary>
    /// Returns true if Event instances are equal
    /// </summary>
    /// <param name="other">Instance of Event to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Event other)
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
            ) &&
            (
                WebEvent == other.WebEvent ||
                WebEvent != null &&
                WebEvent.Equals(other.WebEvent)
            ) &&
            (
                AppEvent == other.AppEvent ||
                AppEvent != null &&
                AppEvent.Equals(other.AppEvent)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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

            if (WebEvent != null)
            {
                hash = hash * 59 + WebEvent.GetHashCode();
            }

            if (AppEvent != null)
            {
                hash = hash * 59 + AppEvent.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
