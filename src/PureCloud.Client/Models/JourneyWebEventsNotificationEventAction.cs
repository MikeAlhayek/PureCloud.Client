using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationEventAction
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public JourneyWebEventsNotificationEventActionStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public JourneyWebEventsNotificationEventActionMediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets Prompt
    /// </summary>
    public string Prompt { get; set; }
}
