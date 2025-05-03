using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhraseAssociations
/// </summary>

public partial class PhraseAssociations : IEquatable<PhraseAssociations>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PhraseAssociations" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PhraseAssociations() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhraseAssociations" /> class.
    /// </summary>
    /// <param name="PhraseId">Id of the phrase to be linked (required).</param>
    /// <param name="DocumentId">Id of the document to be linked (required).</param>
    public PhraseAssociations(string PhraseId = null, string DocumentId = null)
    {
        this.PhraseId = PhraseId;
        this.DocumentId = DocumentId;

    }



    /// <summary>
    /// Id of the phrase to be linked
    /// </summary>
    /// <value>Id of the phrase to be linked</value>
    [JsonPropertyName("phraseId")]
    public string PhraseId { get; set; }



    /// <summary>
    /// Id of the document to be linked
    /// </summary>
    /// <value>Id of the document to be linked</value>
    [JsonPropertyName("documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhraseAssociations {\n");

        sb.Append("  PhraseId: ").Append(PhraseId).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
        return Equals(obj as PhraseAssociations);
    }

    /// <summary>
    /// Returns true if PhraseAssociations instances are equal
    /// </summary>
    /// <param name="other">Instance of PhraseAssociations to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhraseAssociations other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PhraseId == other.PhraseId ||
                PhraseId != null &&
                PhraseId.Equals(other.PhraseId)
            ) &&
            (
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
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
            if (PhraseId != null)
            {
                hash = hash * 59 + PhraseId.GetHashCode();
            }

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
            }

            return hash;
        }
    }
}
