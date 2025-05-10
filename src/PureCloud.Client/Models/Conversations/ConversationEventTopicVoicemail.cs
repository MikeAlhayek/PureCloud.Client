namespace PureCloud.Client.Models.Conversations;

/// <summary>
/// The voicemail data to be used when this callback is an ACD voicemail.
/// </summary>
public sealed class ConversationEventTopicVoicemail
{
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    public ConversationEventTopicVoicemailUploadStatus? UploadStatus { get; set; }

    /// <summary>
    /// The voicemail id
    /// </summary>
    /// <value>The voicemail id</value>
    public string Id { get; set; }
}
