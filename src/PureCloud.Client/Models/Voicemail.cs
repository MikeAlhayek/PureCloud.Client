namespace PureCloud.Client.Models;

public sealed class Voicemail
{
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    public VoicemailUploadStatus? UploadStatus { get; set; }

    /// <summary>
    /// The voicemail id
    /// </summary>
    /// <value>The voicemail id</value>
    public string Id { get; set; }
}
