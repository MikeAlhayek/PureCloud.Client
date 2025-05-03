using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PublishTopicTestPhraseMatchedTranscript
/// </summary>

public partial class PublishTopicTestPhraseMatchedTranscript : IEquatable<PublishTopicTestPhraseMatchedTranscript>
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Call for "call"
        /// </summary>
        [EnumMember(Value = "call")]
        Call,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum All for "all"
        /// </summary>
        [EnumMember(Value = "all")]
        All
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishTopicTestPhraseMatchedTranscript" /> class.
    /// </summary>
    /// <param name="Timestamp">Timestamp.</param>
    /// <param name="TranscriptId">TranscriptId.</param>
    /// <param name="CommunicationId">CommunicationId.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="DetectedPhrases">DetectedPhrases.</param>
    public PublishTopicTestPhraseMatchedTranscript(long? Timestamp = null, string TranscriptId = null, string CommunicationId = null, string ConversationId = null, MediaTypeEnum? MediaType = null, List<PublishTopicTestPhraseDetectedPhrase> DetectedPhrases = null)
    {
        this.Timestamp = Timestamp;
        this.TranscriptId = TranscriptId;
        this.CommunicationId = CommunicationId;
        this.ConversationId = ConversationId;
        this.MediaType = MediaType;
        this.DetectedPhrases = DetectedPhrases;

    }



    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long? Timestamp { get; set; }



    /// <summary>
    /// Gets or Sets TranscriptId
    /// </summary>
    [JsonPropertyName("transcriptId")]
    public string TranscriptId { get; set; }



    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }





    /// <summary>
    /// Gets or Sets DetectedPhrases
    /// </summary>
    [JsonPropertyName("detectedPhrases")]
    public List<PublishTopicTestPhraseDetectedPhrase> DetectedPhrases { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PublishTopicTestPhraseMatchedTranscript {\n");

        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  TranscriptId: ").Append(TranscriptId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  DetectedPhrases: ").Append(DetectedPhrases).Append("\n");
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
        return Equals(obj as PublishTopicTestPhraseMatchedTranscript);
    }

    /// <summary>
    /// Returns true if PublishTopicTestPhraseMatchedTranscript instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishTopicTestPhraseMatchedTranscript to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishTopicTestPhraseMatchedTranscript other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                TranscriptId == other.TranscriptId ||
                TranscriptId != null &&
                TranscriptId.Equals(other.TranscriptId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                DetectedPhrases == other.DetectedPhrases ||
                DetectedPhrases != null &&
                DetectedPhrases.SequenceEqual(other.DetectedPhrases)
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
            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (TranscriptId != null)
            {
                hash = hash * 59 + TranscriptId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (DetectedPhrases != null)
            {
                hash = hash * 59 + DetectedPhrases.GetHashCode();
            }

            return hash;
        }
    }
}
