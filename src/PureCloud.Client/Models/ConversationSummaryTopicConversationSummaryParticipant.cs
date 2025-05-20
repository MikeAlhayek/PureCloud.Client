using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicConversationSummaryParticipant
{
    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    public ConversationSummaryTopicConversationSummaryParticipantPurposeEnum? Purpose { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }
}
