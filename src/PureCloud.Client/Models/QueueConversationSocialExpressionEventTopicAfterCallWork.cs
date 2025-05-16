using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationSocialExpressionEventTopicAfterCallWork
{
    /// <summary>
    /// The communication's after-call work state.
    /// </summary>
    /// <value>The communication's after-call work state.</value>
    public QueueConversationSocialExpressionEventTopicAfterCallWorkStateEnum? State { get; set; }

    /// <summary>
    /// The timestamp when this communication started after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication started after-call work in the cloud clock.</value>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The timestamp when this communication ended after-call work in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication ended after-call work in the cloud clock.</value>
    public DateTime? EndTime { get; set; }
}
