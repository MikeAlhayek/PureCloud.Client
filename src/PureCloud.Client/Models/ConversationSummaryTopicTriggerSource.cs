using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicTriggerSource
{
    /// <summary>
    /// Gets or Sets SourceType
    /// </summary>
    public ConversationSummaryTopicTriggerSourceSourceTypeEnum? SourceType { get; set; }

    /// <summary>
    /// Gets or Sets SourceId
    /// </summary>
    public string SourceId { get; set; }
}
