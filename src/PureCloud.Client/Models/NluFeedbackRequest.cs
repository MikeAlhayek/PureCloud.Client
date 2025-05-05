using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluFeedbackRequest
/// </summary>

public partial class NluFeedbackRequest : IEquatable<NluFeedbackRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluFeedbackRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluFeedbackRequest" /> class.
    /// </summary>
    /// <param name="Text">The feedback text. (required).</param>
    /// <param name="Intents">Detected intent of the utterance (required).</param>
    /// <param name="VersionId">The domain version ID of the feedback. (required).</param>
    /// <param name="Language">The language of the version to which feedback is linked, e.g. en-us, de-de.</param>
    public NluFeedbackRequest(string Text = null, List<IntentFeedback> Intents = null, string VersionId = null, string Language = null)
    {
        this.Text = Text;
        this.Intents = Intents;
        this.VersionId = VersionId;
        this.Language = Language;

    }



    /// <summary>
    /// The feedback text.
    /// </summary>
    /// <value>The feedback text.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Detected intent of the utterance
    /// </summary>
    /// <value>Detected intent of the utterance</value>
    [JsonPropertyName("intents")]
    public List<IntentFeedback> Intents { get; set; }



    /// <summary>
    /// The domain version ID of the feedback.
    /// </summary>
    /// <value>The domain version ID of the feedback.</value>
    [JsonPropertyName("versionId")]
    public string VersionId { get; set; }



    /// <summary>
    /// The language of the version to which feedback is linked, e.g. en-us, de-de
    /// </summary>
    /// <value>The language of the version to which feedback is linked, e.g. en-us, de-de</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluFeedbackRequest {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
        sb.Append("  VersionId: ").Append(VersionId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
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
        return Equals(obj as NluFeedbackRequest);
    }

    /// <summary>
    /// Returns true if NluFeedbackRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of NluFeedbackRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluFeedbackRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
            ) &&
            (
                VersionId == other.VersionId ||
                VersionId != null &&
                VersionId.Equals(other.VersionId)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (VersionId != null)
            {
                hash = hash * 59 + VersionId.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            return hash;
        }
    }
}
