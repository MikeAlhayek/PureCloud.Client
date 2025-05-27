using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AgentDirectRoutingBackupSettings
{
    /// <summary>
    /// ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.
    /// </summary>
    /// <value>ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.</value>
    public string QueueId { get; set; }

    /// <summary>
    /// ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.
    /// </summary>
    /// <value>ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.</value>
    public string UserId { get; set; }

    /// <summary>
    /// Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.
    /// </summary>
    /// <value>Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.</value>
    public bool? WaitForAgent { get; set; }

    /// <summary>
    /// Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].
    /// </summary>
    /// <value>Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].</value>
    public int? AgentWaitSeconds { get; set; }

    /// <summary>
    /// Set of users that this user is a backup for.
    /// </summary>
    /// <value>Set of users that this user is a backup for.</value>
    public IEnumerable<string> BackedUpUsers { get; set; }
}
