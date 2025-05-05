using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhraseTranslation
/// </summary>

public partial class PhraseTranslation : IEquatable<PhraseTranslation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PhraseTranslation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PhraseTranslation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhraseTranslation" /> class.
    /// </summary>
    /// <param name="StartTimeMs">Epoch start time of the phrase (required).</param>
    /// <param name="ParticipantPurpose">Purpose of the participant associated with the phrase (required).</param>
    /// <param name="TranslatedText">Translation of the phrase (required).</param>
    public PhraseTranslation(long? StartTimeMs = null, string ParticipantPurpose = null, string TranslatedText = null)
    {
        this.StartTimeMs = StartTimeMs;
        this.ParticipantPurpose = ParticipantPurpose;
        this.TranslatedText = TranslatedText;

    }



    /// <summary>
    /// Epoch start time of the phrase
    /// </summary>
    /// <value>Epoch start time of the phrase</value>
    [JsonPropertyName("startTimeMs")]
    public long? StartTimeMs { get; set; }



    /// <summary>
    /// Purpose of the participant associated with the phrase
    /// </summary>
    /// <value>Purpose of the participant associated with the phrase</value>
    [JsonPropertyName("participantPurpose")]
    public string ParticipantPurpose { get; set; }



    /// <summary>
    /// Translation of the phrase
    /// </summary>
    /// <value>Translation of the phrase</value>
    [JsonPropertyName("translatedText")]
    public string TranslatedText { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhraseTranslation {\n");

        sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
        sb.Append("  ParticipantPurpose: ").Append(ParticipantPurpose).Append("\n");
        sb.Append("  TranslatedText: ").Append(TranslatedText).Append("\n");
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
        return Equals(obj as PhraseTranslation);
    }

    /// <summary>
    /// Returns true if PhraseTranslation instances are equal
    /// </summary>
    /// <param name="other">Instance of PhraseTranslation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhraseTranslation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartTimeMs == other.StartTimeMs ||
                StartTimeMs != null &&
                StartTimeMs.Equals(other.StartTimeMs)
            ) &&
            (
                ParticipantPurpose == other.ParticipantPurpose ||
                ParticipantPurpose != null &&
                ParticipantPurpose.Equals(other.ParticipantPurpose)
            ) &&
            (
                TranslatedText == other.TranslatedText ||
                TranslatedText != null &&
                TranslatedText.Equals(other.TranslatedText)
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
            if (StartTimeMs != null)
            {
                hash = hash * 59 + StartTimeMs.GetHashCode();
            }

            if (ParticipantPurpose != null)
            {
                hash = hash * 59 + ParticipantPurpose.GetHashCode();
            }

            if (TranslatedText != null)
            {
                hash = hash * 59 + TranslatedText.GetHashCode();
            }

            return hash;
        }
    }
}
