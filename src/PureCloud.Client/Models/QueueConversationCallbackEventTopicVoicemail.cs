using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationCallbackEventTopicVoicemail
{
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    public QueueConversationCallbackEventTopicVoicemailUploadStatusEnum? UploadStatus { get; set; }

    /// <summary>
    /// The voicemail id
    /// </summary>
    /// <value>The voicemail id</value>
    public string Id { get; set; }
}
