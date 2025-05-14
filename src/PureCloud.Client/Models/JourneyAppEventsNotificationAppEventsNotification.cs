using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationAppEventsNotification
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public JourneyAppEventsNotificationAppEventsNotificationEventTypeEnum? EventType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    public JourneyAppEventsNotificationExternalContact ExternalContact { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets CustomerIdType
    /// </summary>
    public string CustomerIdType { get; set; }

    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    public JourneyAppEventsNotificationSession Session { get; set; }

    /// <summary>
    /// Gets or Sets AppEvent
    /// </summary>
    public JourneyAppEventsNotificationAppMessage AppEvent { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeAchievedEvent
    /// </summary>
    public JourneyAppEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }

    /// <summary>
    /// Gets or Sets SegmentAssignmentEvent
    /// </summary>
    public JourneyAppEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent { get; set; }

    /// <summary>
    /// Gets or Sets WebActionEvent
    /// </summary>
    public JourneyAppEventsNotificationWebActionMessage WebActionEvent { get; set; }
}
