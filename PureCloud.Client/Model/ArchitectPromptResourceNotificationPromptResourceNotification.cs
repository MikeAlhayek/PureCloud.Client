using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ArchitectPromptResourceNotificationPromptResourceNotification
    /// </summary>
    [DataContract]
    public partial class ArchitectPromptResourceNotificationPromptResourceNotification : IEquatable<ArchitectPromptResourceNotificationPromptResourceNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectPromptResourceNotificationPromptResourceNotification" /> class.
        /// </summary>
        /// <param name="PromptId">Id of the prompt that this notification is for..</param>
        /// <param name="Id">Id of the prompt resource that this notification is for..</param>
        /// <param name="Language">Language resource that this notification is for..</param>
        /// <param name="MediaUri">Uri to the file for this prompt resource..</param>
        /// <param name="UploadStatus">Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed)..</param>
        /// <param name="DurationSeconds">Duration (in seconds) for the transcoded audio file..</param>
        public ArchitectPromptResourceNotificationPromptResourceNotification(string PromptId = null, string Id = null, string Language = null, string MediaUri = null, string UploadStatus = null, double? DurationSeconds = null)
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
        [DataMember(Name = "promptId", EmitDefaultValue = false)]
        public string PromptId { get; set; }



        /// <summary>
        /// Id of the prompt resource that this notification is for.
        /// </summary>
        /// <value>Id of the prompt resource that this notification is for.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }



        /// <summary>
        /// Language resource that this notification is for.
        /// </summary>
        /// <value>Language resource that this notification is for.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }



        /// <summary>
        /// Uri to the file for this prompt resource.
        /// </summary>
        /// <value>Uri to the file for this prompt resource.</value>
        [DataMember(Name = "mediaUri", EmitDefaultValue = false)]
        public string MediaUri { get; set; }



        /// <summary>
        /// Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).
        /// </summary>
        /// <value>Current upload status of the prompt resource (created, uploaded, transcoded, transcodeFailed).</value>
        [DataMember(Name = "uploadStatus", EmitDefaultValue = false)]
        public string UploadStatus { get; set; }



        /// <summary>
        /// Duration (in seconds) for the transcoded audio file.
        /// </summary>
        /// <value>Duration (in seconds) for the transcoded audio file.</value>
        [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
        public double? DurationSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectPromptResourceNotificationPromptResourceNotification {\n");

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
            return this.Equals(obj as ArchitectPromptResourceNotificationPromptResourceNotification);
        }

        /// <summary>
        /// Returns true if ArchitectPromptResourceNotificationPromptResourceNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectPromptResourceNotificationPromptResourceNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectPromptResourceNotificationPromptResourceNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
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
                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();

                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
