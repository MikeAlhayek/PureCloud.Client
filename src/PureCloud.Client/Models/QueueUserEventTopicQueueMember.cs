using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueUserEventTopicQueueMember
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public QueueUserEventTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    public string QueueId { get; set; }

    /// <summary>
    /// Gets or Sets Joined
    /// </summary>
    public bool? Joined { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
