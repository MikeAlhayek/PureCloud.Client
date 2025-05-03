namespace PureCloud.Client.Models;

/// <summary>
/// DirectRouting
/// </summary>

public sealed class DirectRouting
{
    /// <summary>
    /// Direct Routing Settings specific to Call media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Call media.</value>
    public DirectRoutingMediaSettings CallMediaSettings { get; set; }

    /// <summary>
    /// Direct Routing Settings specific to Email media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Email media.</value>
    public DirectRoutingMediaSettings EmailMediaSettings { get; set; }

    /// <summary>
    /// Direct Routing Settings specific to Message media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Message media.</value>
    public DirectRoutingMediaSettings MessageMediaSettings { get; set; }

    /// <summary>
    /// ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation.
    /// </summary>
    /// <value>ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation.</value>
    public string BackupQueueId { get; set; }

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
}
