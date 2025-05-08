using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationConversationUserDisposition
{
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public JourneySessionEventsNotificationUser User { get; set; }
}
