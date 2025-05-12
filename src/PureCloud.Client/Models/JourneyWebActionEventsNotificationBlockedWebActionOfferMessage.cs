using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebActionEventsNotificationBlockedWebActionOfferMessage
{
    /// <summary>
    /// Gets or Sets BlockingReason
    /// </summary>
    public JourneyWebActionEventsNotificationBlockedWebActionOfferMessageBlockingReasonEnum? BlockingReason { get; set; }

    /// <summary>
    /// Gets or Sets BlockingFrequencyCapBehaviour
    /// </summary>
    public JourneyWebActionEventsNotificationBlockedWebActionOfferMessageBlockingFrequencyCapBehaviourEnum? BlockingFrequencyCapBehaviour { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public JourneyWebActionEventsNotificationEventAction Action { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public JourneyWebActionEventsNotificationActionMap ActionMap { get; set; }

    /// <summary>
    /// Gets or Sets ActionTarget
    /// </summary>
    public JourneyWebActionEventsNotificationActionTarget ActionTarget { get; set; }

    /// <summary>
    /// Gets or Sets BlockingActionMap
    /// </summary>
    public JourneyWebActionEventsNotificationActionMap BlockingActionMap { get; set; }

    /// <summary>
    /// Gets or Sets BlockingAction
    /// </summary>
    public JourneyWebActionEventsNotificationEventAction BlockingAction { get; set; }

    /// <summary>
    /// Gets or Sets BlockingPageUrlConditions
    /// </summary>
    public IEnumerable<JourneyWebActionEventsNotificationActionMapPageUrlCondition> BlockingPageUrlConditions { get; set; }

    /// <summary>
    /// Gets or Sets BlockingScheduleGroup
    /// </summary>
    public JourneyWebActionEventsNotificationScheduleGroup BlockingScheduleGroup { get; set; }

    /// <summary>
    /// Gets or Sets BlockingEmergencyScheduleGroup
    /// </summary>
    public JourneyWebActionEventsNotificationEmergencyGroup BlockingEmergencyScheduleGroup { get; set; }
}
