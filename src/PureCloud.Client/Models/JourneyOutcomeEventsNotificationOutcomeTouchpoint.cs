using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationOutcomeTouchpoint
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Channels
    /// </summary>
    public IEnumerable<JourneyOutcomeEventsNotificationOutcomeTouchpointChannel> Channels { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public JourneyOutcomeEventsNotificationActionMap ActionMap { get; set; }
}
