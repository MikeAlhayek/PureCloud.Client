using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationWebEventsNotification
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public JourneyWebEventsNotificationWebEventsNotificationEventTypeEnum? EventType { get; set; }

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
    public JourneyWebEventsNotificationExternalContact ExternalContact { get; set; }

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
    public JourneyWebEventsNotificationSession Session { get; set; }

    /// <summary>
    /// Gets or Sets WebEvent
    /// </summary>
    public JourneyWebEventsNotificationWebMessage WebEvent { get; set; }

    /// <summary>
    /// Gets or Sets WebActionEvent
    /// </summary>
    public JourneyWebEventsNotificationWebActionMessage WebActionEvent { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeAchievedEvent
    /// </summary>
    public JourneyWebEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }

    /// <summary>
    /// Gets or Sets SegmentAssignmentEvent
    /// </summary>
    public JourneyWebEventsNotificationSegmentAssignmentMessage SegmentAssignmentEvent { get; set; }
}
