using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification
/// </summary>

public partial class ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification : IEquatable<ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification" /> class.
    /// </summary>
    /// <param name="PromptId">Id of the prompt that this notification is for..</param>
    /// <param name="Id">Id of the prompt resource that this notification is for..</param>
    /// <param name="Language">Language resource that this notification is for..</param>
    /// <param name="MediaUri">Uri to the file for this system prompt resource..</param>
    /// <param name="UploadStatus">Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed)..</param>
    /// <param name="DurationSeconds">Duration (in seconds) for the transcoded audio file..</param>
    public ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification(string PromptId = null, string Id = null, string Language = null, string MediaUri = null, string UploadStatus = null, double? DurationSeconds = null)
    {
        this.PromptId = PromptId;
        this.Id = Id;
        this.Language = Language;
        this.MediaUri = MediaUri;
        this.UploadStatus = UploadStatus;
        this.DurationSeconds = DurationSeconds;

    }



    /// <summary>
    /// Id of the prompt that this notification is for.
    /// </summary>
    /// <value>Id of the prompt that this notification is for.</value>
    [JsonPropertyName("promptId")]
    public string PromptId { get; set; }



    /// <summary>
    /// Id of the prompt resource that this notification is for.
    /// </summary>
    /// <value>Id of the prompt resource that this notification is for.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Language resource that this notification is for.
    /// </summary>
    /// <value>Language resource that this notification is for.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// Uri to the file for this system prompt resource.
    /// </summary>
    /// <value>Uri to the file for this system prompt resource.</value>
    [JsonPropertyName("mediaUri")]
    public string MediaUri { get; set; }



    /// <summary>
    /// Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).
    /// </summary>
    /// <value>Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).</value>
    [JsonPropertyName("uploadStatus")]
    public string UploadStatus { get; set; }



    /// <summary>
    /// Duration (in seconds) for the transcoded audio file.
    /// </summary>
    /// <value>Duration (in seconds) for the transcoded audio file.</value>
    [JsonPropertyName("durationSeconds")]
    public double? DurationSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification {\n");

        sb.Append("  PromptId: ").Append(PromptId).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification);
    }

    /// <summary>
    /// Returns true if ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PromptId == other.PromptId ||
                PromptId != null &&
                PromptId.Equals(other.PromptId)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                MediaUri == other.MediaUri ||
                MediaUri != null &&
                MediaUri.Equals(other.MediaUri)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
            ) &&
            (
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (PromptId != null)
            {
                hash = hash * 59 + PromptId.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (MediaUri != null)
            {
                hash = hash * 59 + MediaUri.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
