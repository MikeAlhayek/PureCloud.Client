using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationEventAction
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public JourneyAppEventsNotificationEventActionStateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    /// 
    public JourneyAppEventsNotificationEventActionMediaTypeEnum? MediaType { get; set; }

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
