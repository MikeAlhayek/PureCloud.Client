using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

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
        return Equals(obj as RecordingTranscodeCompleteTopicRecording);
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
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                FileState == other.FileState ||
                FileState != null &&
                FileState.Equals(other.FileState)
            ) &&
            (
                MediaUris == other.MediaUris ||
                MediaUris != null &&
                MediaUris.SequenceEqual(other.MediaUris)
            ) &&
            (
                EstimatedTranscodeTimeMs == other.EstimatedTranscodeTimeMs ||
                EstimatedTranscodeTimeMs != null &&
                EstimatedTranscodeTimeMs.Equals(other.EstimatedTranscodeTimeMs)
            ) &&
            (
                ActualTranscodeTimeMs == other.ActualTranscodeTimeMs ||
                ActualTranscodeTimeMs != null &&
                ActualTranscodeTimeMs.Equals(other.ActualTranscodeTimeMs)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (FileState != null)
            {
                hash = hash * 59 + FileState.GetHashCode();
            }

            if (MediaUris != null)
            {
                hash = hash * 59 + MediaUris.GetHashCode();
            }

            if (EstimatedTranscodeTimeMs != null)
            {
                hash = hash * 59 + EstimatedTranscodeTimeMs.GetHashCode();
            }

            if (ActualTranscodeTimeMs != null)
            {
                hash = hash * 59 + ActualTranscodeTimeMs.GetHashCode();
            }

            return hash;
        }
    }
}
