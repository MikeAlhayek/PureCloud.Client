using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// RecordingTranscodeCompleteTopicRecording
/// </summary>
[DataContract]
public partial class RecordingTranscodeCompleteTopicRecording : IEquatable<RecordingTranscodeCompleteTopicRecording>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingTranscodeCompleteTopicRecording" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="FileState">FileState.</param>
    /// <param name="MediaUris">MediaUris.</param>
    /// <param name="EstimatedTranscodeTimeMs">EstimatedTranscodeTimeMs.</param>
    /// <param name="ActualTranscodeTimeMs">ActualTranscodeTimeMs.</param>
    public RecordingTranscodeCompleteTopicRecording(string Id = null, string ConversationId = null, string FileState = null, List<RecordingTranscodeCompleteTopicMediaResult> MediaUris = null, long? EstimatedTranscodeTimeMs = null, long? ActualTranscodeTimeMs = null)
    {
        this.Id = Id;
        this.ConversationId = ConversationId;
        this.FileState = FileState;
        this.MediaUris = MediaUris;
        this.EstimatedTranscodeTimeMs = EstimatedTranscodeTimeMs;
        this.ActualTranscodeTimeMs = ActualTranscodeTimeMs;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets FileState
    /// </summary>
    [DataMember(Name = "fileState", EmitDefaultValue = false)]
    public string FileState { get; set; }



    /// <summary>
    /// Gets or Sets MediaUris
    /// </summary>
    [DataMember(Name = "mediaUris", EmitDefaultValue = false)]
    public List<RecordingTranscodeCompleteTopicMediaResult> MediaUris { get; set; }



    /// <summary>
    /// Gets or Sets EstimatedTranscodeTimeMs
    /// </summary>
    [DataMember(Name = "estimatedTranscodeTimeMs", EmitDefaultValue = false)]
    public long? EstimatedTranscodeTimeMs { get; set; }



    /// <summary>
    /// Gets or Sets ActualTranscodeTimeMs
    /// </summary>
    [DataMember(Name = "actualTranscodeTimeMs", EmitDefaultValue = false)]
    public long? ActualTranscodeTimeMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingTranscodeCompleteTopicRecording {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  FileState: ").Append(FileState).Append("\n");
        sb.Append("  MediaUris: ").Append(MediaUris).Append("\n");
        sb.Append("  EstimatedTranscodeTimeMs: ").Append(EstimatedTranscodeTimeMs).Append("\n");
        sb.Append("  ActualTranscodeTimeMs: ").Append(ActualTranscodeTimeMs).Append("\n");
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
        return this.Equals(obj as RecordingTranscodeCompleteTopicRecording);
    }

    /// <summary>
    /// Returns true if RecordingTranscodeCompleteTopicRecording instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingTranscodeCompleteTopicRecording to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingTranscodeCompleteTopicRecording other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.ConversationId == other.ConversationId ||
                this.ConversationId != null &&
                this.ConversationId.Equals(other.ConversationId)
            ) &&
            (
                this.FileState == other.FileState ||
                this.FileState != null &&
                this.FileState.Equals(other.FileState)
            ) &&
            (
                this.MediaUris == other.MediaUris ||
                this.MediaUris != null &&
                this.MediaUris.SequenceEqual(other.MediaUris)
            ) &&
            (
                this.EstimatedTranscodeTimeMs == other.EstimatedTranscodeTimeMs ||
                this.EstimatedTranscodeTimeMs != null &&
                this.EstimatedTranscodeTimeMs.Equals(other.EstimatedTranscodeTimeMs)
            ) &&
            (
                this.ActualTranscodeTimeMs == other.ActualTranscodeTimeMs ||
                this.ActualTranscodeTimeMs != null &&
                this.ActualTranscodeTimeMs.Equals(other.ActualTranscodeTimeMs)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.ConversationId != null)
            {
                hash = hash * 59 + this.ConversationId.GetHashCode();
            }

            if (this.FileState != null)
            {
                hash = hash * 59 + this.FileState.GetHashCode();
            }

            if (this.MediaUris != null)
            {
                hash = hash * 59 + this.MediaUris.GetHashCode();
            }

            if (this.EstimatedTranscodeTimeMs != null)
            {
                hash = hash * 59 + this.EstimatedTranscodeTimeMs.GetHashCode();
            }

            if (this.ActualTranscodeTimeMs != null)
            {
                hash = hash * 59 + this.ActualTranscodeTimeMs.GetHashCode();
            }

            return hash;
        }
    }
}
