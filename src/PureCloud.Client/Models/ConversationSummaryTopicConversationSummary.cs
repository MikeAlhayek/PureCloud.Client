using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicConversationSummary
{
    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    public double? Score { get; set; }
}
