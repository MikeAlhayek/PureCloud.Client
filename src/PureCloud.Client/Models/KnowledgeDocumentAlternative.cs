using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentAlternative
/// </summary>

public partial class KnowledgeDocumentAlternative : IEquatable<KnowledgeDocumentAlternative>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentAlternative" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentAlternative() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentAlternative" /> class.
    /// </summary>
    /// <param name="Phrase">Alternate phrasing to the document title, having a limit of 500 words. (required).</param>
    /// <param name="Autocomplete">Autocomplete enabled for the alternate phrase. (required).</param>
    public KnowledgeDocumentAlternative(string Phrase = null, bool? Autocomplete = null)
    {
        this.Phrase = Phrase;
        this.Autocomplete = Autocomplete;

    }



    /// <summary>
    /// Alternate phrasing to the document title, having a limit of 500 words.
    /// </summary>
    /// <value>Alternate phrasing to the document title, having a limit of 500 words.</value>
    [JsonPropertyName("phrase")]
    public string Phrase { get; set; }



    /// <summary>
    /// Autocomplete enabled for the alternate phrase.
    /// </summary>
    /// <value>Autocomplete enabled for the alternate phrase.</value>
    [JsonPropertyName("autocomplete")]
    public bool? Autocomplete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentAlternative {\n");

        sb.Append("  Phrase: ").Append(Phrase).Append("\n");
        sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
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
        return Equals(obj as KnowledgeDocumentAlternative);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentAlternative instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentAlternative to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentAlternative other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Phrase == other.Phrase ||
                Phrase != null &&
                Phrase.Equals(other.Phrase)
            ) &&
            (
                Autocomplete == other.Autocomplete ||
                Autocomplete != null &&
                Autocomplete.Equals(other.Autocomplete)
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
            if (Phrase != null)
            {
                hash = hash * 59 + Phrase.GetHashCode();
            }

            if (Autocomplete != null)
            {
                hash = hash * 59 + Autocomplete.GetHashCode();
            }

            return hash;
        }
    }
}
