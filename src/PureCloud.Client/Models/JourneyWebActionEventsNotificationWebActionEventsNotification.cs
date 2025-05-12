using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebActionEventsNotificationWebActionEventsNotification
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public JourneyWebActionEventsNotificationWebActionEventsNotificationEventTypeEnum? EventType { get; set; }

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
    public JourneyWebActionEventsNotificationExternalContact ExternalContact { get; set; }

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
    public JourneyWebActionEventsNotificationSession Session { get; set; }

    /// <summary>
    /// Gets or Sets WebActionEvent
    /// </summary>
    public JourneyWebActionEventsNotificationWebActionMessage WebActionEvent { get; set; }

    /// <summary>
    /// Gets or Sets BlockedWebActionOfferEvent
    /// </summary>
    public JourneyWebActionEventsNotificationBlockedWebActionOfferMessage BlockedWebActionOfferEvent { get; set; }
}
