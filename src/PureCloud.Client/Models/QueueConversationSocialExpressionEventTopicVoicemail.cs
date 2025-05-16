using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationSocialExpressionEventTopicVoicemail
{
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    public QueueConversationSocialExpressionEventTopicVoicemailUploadStatusEnum? UploadStatus { get; set; }

    /// <summary>
    /// The voicemail id
    /// </summary>
    /// <value>The voicemail id</value>
    public string Id { get; set; }
}
