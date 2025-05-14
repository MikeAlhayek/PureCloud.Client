using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationOutcomeAttributionMessage
{
    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    public JourneyOutcomeEventsNotificationOutcome Outcome { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeTouchpoints
    /// </summary>
    public IEnumerable<JourneyOutcomeEventsNotificationOutcomeTouchpoint> OutcomeTouchpoints { get; set; }

    /// <summary>
    /// Gets or Sets SegmentAssignments
    /// </summary>
    public IEnumerable<JourneyOutcomeEventsNotificationSegment> SegmentAssignments { get; set; }

    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    public JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue { get; set; }
}
