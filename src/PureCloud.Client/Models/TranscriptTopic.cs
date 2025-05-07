using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptTopic
/// </summary>

public partial class TranscriptTopic : IEquatable<TranscriptTopic>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptTopic" /> class.
    /// </summary>
    /// <param name="Duration">Duration.</param>
    public TranscriptTopic(TopicDuration Duration = null)
    {
        this.Duration = Duration;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The phrase which detected the topic. 
    /// </summary>
    /// <value>The phrase which detected the topic. </value>
    [JsonPropertyName("topicPhrase")]
    public string TopicPhrase { get; set; }



    /// <summary>
    /// The transcript phrase which detected the topic.
    /// </summary>
    /// <value>The transcript phrase which detected the topic.</value>
    [JsonPropertyName("transcriptPhrase")]
    public string TranscriptPhrase { get; set; }



    /// <summary>
    /// The detection confidence of the topic.
    /// </summary>
    /// <value>The detection confidence of the topic.</value>
    [JsonPropertyName("confidence")]
    public int? Confidence { get; set; }



    /// <summary>
    /// The start time of the topic phrase.
    /// </summary>
    /// <value>The start time of the topic phrase.</value>
    [JsonPropertyName("startTimeMilliseconds")]
    public long? StartTimeMilliseconds { get; set; }



    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [JsonPropertyName("duration")]
    public TopicDuration Duration { get; set; }



    /// <summary>
    /// Location of the phrase
    /// </summary>
    /// <value>Location of the phrase</value>
    [JsonPropertyName("offset")]
    public TopicOffset Offset { get; set; }



    /// <summary>
    /// Location of the phrase in the recording in milliseconds
    /// </summary>
    /// <value>Location of the phrase in the recording in milliseconds</value>
    [JsonPropertyName("recordingLocation")]
    public long? RecordingLocation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptTopic {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TopicPhrase: ").Append(TopicPhrase).Append("\n");
        sb.Append("  TranscriptPhrase: ").Append(TranscriptPhrase).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  StartTimeMilliseconds: ").Append(StartTimeMilliseconds).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
        sb.Append("  Offset: ").Append(Offset).Append("\n");
        sb.Append("  RecordingLocation: ").Append(RecordingLocation).Append("\n");
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
        return Equals(obj as TranscriptTopic);
    }

    /// <summary>
    /// Returns true if TranscriptTopic instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptTopic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptTopic other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                TopicPhrase == other.TopicPhrase ||
                TopicPhrase != null &&
                TopicPhrase.Equals(other.TopicPhrase)
            ) &&
            (
                TranscriptPhrase == other.TranscriptPhrase ||
                TranscriptPhrase != null &&
                TranscriptPhrase.Equals(other.TranscriptPhrase)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
            ) &&
            (
                StartTimeMilliseconds == other.StartTimeMilliseconds ||
                StartTimeMilliseconds != null &&
                StartTimeMilliseconds.Equals(other.StartTimeMilliseconds)
            ) &&
            (
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
            ) &&
            (
                Offset == other.Offset ||
                Offset != null &&
                Offset.Equals(other.Offset)
            ) &&
            (
                RecordingLocation == other.RecordingLocation ||
                RecordingLocation != null &&
                RecordingLocation.Equals(other.RecordingLocation)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (TopicPhrase != null)
            {
                hash = hash * 59 + TopicPhrase.GetHashCode();
            }

            if (TranscriptPhrase != null)
            {
                hash = hash * 59 + TranscriptPhrase.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (StartTimeMilliseconds != null)
            {
                hash = hash * 59 + StartTimeMilliseconds.GetHashCode();
            }

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            if (Offset != null)
            {
                hash = hash * 59 + Offset.GetHashCode();
            }

            if (RecordingLocation != null)
            {
                hash = hash * 59 + RecordingLocation.GetHashCode();
            }

            return hash;
        }
    }
}
