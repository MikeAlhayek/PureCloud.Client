using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Conversations;

namespace PureCloud.Client.Models;

public sealed class ConversationNormalizedMessage
{
    public ConversationNormalizedMessageTypeEnum? Type { get; set; }

    public Status Status { get; set; }

    public OriginatingEntity? OriginatingEntity { get; set; }

    public Direction? Direction { get; set; }

    public string Id { get; set; }      

    public ConversationMessagingChannel Channel { get; set; }

    public string Text { get; set; }

    public IEnumerable<ConversationMessageContent> Content { get; set; }

    public IEnumerable<ConversationMessageEvent> Events { get; set; }

    public IEnumerable<ConversationReason> Reasons { get; set; }

    public bool? IsFinalReceipt { get; set; }

    public Dictionary<string, string> Metadata { get; set; }

    public string ByoSmsIntegrationId { get; set; }
}
