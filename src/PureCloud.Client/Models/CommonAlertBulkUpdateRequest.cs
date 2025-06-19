using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonAlertBulkUpdateRequest
{
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    public CommonAlertBulkUpdateRequestTypeEnum? Type { get; set; }

    /// <summary>
    /// The user supplied alert ids to be muted
    /// </summary>
    /// <value>The user supplied alert ids to be muted</value>
    public IEnumerable<string> AlertIds { get; set; }

    /// <summary>
    /// The fields need for a mute or snooze requests
    /// </summary>
    /// <value>The fields need for a mute or snooze requests</value>
    public MuteSnoozeFields MuteSnooze { get; set; }

    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    public UnreadFields Unread { get; set; }
}
