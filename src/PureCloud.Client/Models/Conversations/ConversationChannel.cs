using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationChannel
{
    /// <summary>
    /// The type or category of this channel.
    /// </summary>
    /// <value>The type or category of this channel.</value>
    public ConversationChannelTypeEnum? Type { get; set; }

    /// <summary>
    /// Message type for messaging conversations.
    /// </summary>
    /// <value>Message type for messaging conversations.</value>
    public ConversationChannelMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// The source provider for the conversation (e.g. Edge, PureCloudEnvironment Messaging, PureCloudEnvironment Email).
    /// </summary>
    /// <value>The source provider for the conversation (e.g. Edge, PureCloudEnvironment Messaging, PureCloudEnvironment Email).</value>
    public string Platform { get; set; }
}
