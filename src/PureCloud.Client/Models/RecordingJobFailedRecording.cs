using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingJobFailedRecording
/// </summary>

public partial class RecordingJobFailedRecording : IEquatable<RecordingJobFailedRecording>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingJobFailedRecording" /> class.
    /// </summary>
    public RecordingJobFailedRecording()
    {

    }



    /// <summary>
    /// Conversation
    /// </summary>
    /// <value>Conversation</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// Recording
    /// </summary>
    /// <value>Recording</value>
    [JsonPropertyName("recording")]
    public AddressableEntityRef Recording { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingJobFailedRecording {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
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
        return Equals(obj as RecordingJobFailedRecording);
    }

    /// <summary>
    /// Returns true if RecordingJobFailedRecording instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingJobFailedRecording to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingJobFailedRecording other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Recording == other.Recording ||
                Recording != null &&
                Recording.Equals(other.Recording)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            return hash;
        }
    }
}
