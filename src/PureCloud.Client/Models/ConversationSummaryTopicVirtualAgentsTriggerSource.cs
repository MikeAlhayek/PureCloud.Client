using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicVirtualAgentsTriggerSource
{
    /// <summary>
    /// Gets or Sets SourceType
    /// </summary>
    public ConversationSummaryTopicVirtualAgentsTriggerSourceSourceTypeEnum? SourceType { get; set; }

    /// <summary>
    /// Gets or Sets SourceId
    /// </summary>
    public string SourceId { get; set; }
}
