using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptTranslation
/// </summary>

public partial class TranscriptTranslation : IEquatable<TranscriptTranslation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptTranslation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TranscriptTranslation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptTranslation" /> class.
    /// </summary>
    /// <param name="Id">Transcript Id (required).</param>
    /// <param name="Phrases">List of translated phrases, if translation succeeded.</param>
    /// <param name="TranslateError">Translation error, if translation failed.</param>
    public TranscriptTranslation(string Id = null, List<PhraseTranslation> Phrases = null, string TranslateError = null)
    {
        this.Id = Id;
        this.Phrases = Phrases;
        this.TranslateError = TranslateError;

    }



    /// <summary>
    /// Transcript Id
    /// </summary>
    /// <value>Transcript Id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// List of translated phrases, if translation succeeded
    /// </summary>
    /// <value>List of translated phrases, if translation succeeded</value>
    [JsonPropertyName("phrases")]
    public List<PhraseTranslation> Phrases { get; set; }



    /// <summary>
    /// Translation error, if translation failed
    /// </summary>
    /// <value>Translation error, if translation failed</value>
    [JsonPropertyName("translateError")]
    public string TranslateError { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptTranslation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Phrases: ").Append(Phrases).Append("\n");
        sb.Append("  TranslateError: ").Append(TranslateError).Append("\n");
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
        return Equals(obj as TranscriptTranslation);
    }

    /// <summary>
    /// Returns true if TranscriptTranslation instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptTranslation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptTranslation other)
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
                Phrases == other.Phrases ||
                Phrases != null &&
                Phrases.SequenceEqual(other.Phrases)
            ) &&
            (
                TranslateError == other.TranslateError ||
                TranslateError != null &&
                TranslateError.Equals(other.TranslateError)
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

            if (Phrases != null)
            {
                hash = hash * 59 + Phrases.GetHashCode();
            }

            if (TranslateError != null)
            {
                hash = hash * 59 + TranslateError.GetHashCode();
            }

            return hash;
        }
    }
}
