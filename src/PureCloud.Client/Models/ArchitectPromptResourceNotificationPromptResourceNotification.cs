using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectPromptResourceNotificationPromptResourceNotification
{
    /// <summary>
    /// Id of the prompt that this notification is for.
    /// </summary>
    /// <value>Id of the prompt that this notification is for.</value>
    public string PromptId { get; set; }


    /// <summary>
    /// Id of the prompt resource that this notification is for.
    /// </summary>
    /// <value>Id of the prompt resource that this notification is for.</value>
    public string Id { get; set; }


    /// <summary>
    /// Language resource that this notification is for.
    /// </summary>
    /// <value>Language resource that this notification is for.</value>
    public string Language { get; set; }


    /// <summary>
    /// Uri to the file for this prompt resource.
    /// </summary>
    /// <value>Uri to the file for this prompt resource.</value>
    public string MediaUri { get; set; }


    /// <summary>
    /// Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).
    /// </summary>
    /// <value>Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).</value>
    public string UploadStatus { get; set; }


    /// <summary>
    /// Duration (in seconds) for the transcoded audio file.
    /// </summary>
    /// <value>Duration (in seconds) for the transcoded audio file.</value>
    public double? DurationSeconds { get; set; }
}
