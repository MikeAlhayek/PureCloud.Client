using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationOutcomeEventsNotification
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public JourneyOutcomeEventsNotificationOutcomeEventsNotificationEventTypeEnum? EventType { get; set; }

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
    public JourneyOutcomeEventsNotificationExternalContact ExternalContact { get; set; }

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
    public JourneyOutcomeEventsNotificationSession Session { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeAchievedEvent
    /// </summary>
    public JourneyOutcomeEventsNotificationOutcomeAchievedMessage OutcomeAchievedEvent { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeAttributionEventMessage
    /// </summary>
    public JourneyOutcomeEventsNotificationOutcomeAttributionMessage OutcomeAttributionEventMessage { get; set; }
}
