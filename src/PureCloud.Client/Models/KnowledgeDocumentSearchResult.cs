using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentSearchResult
/// </summary>

public partial class KnowledgeDocumentSearchResult : IEquatable<KnowledgeDocumentSearchResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentSearchResult" /> class.
    /// </summary>
    /// <param name="Confidence">The confidence associated with a document with respect to a search query..</param>
    /// <param name="Document">Document that matched the query..</param>
    public KnowledgeDocumentSearchResult(double? Confidence = null, KnowledgeSearchDocumentResponse Document = null)
    {
        this.Confidence = Confidence;
        this.Document = Document;

    }



    /// <summary>
    /// The confidence associated with a document with respect to a search query.
    /// </summary>
    /// <value>The confidence associated with a document with respect to a search query.</value>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }



    /// <summary>
    /// Document that matched the query.
    /// </summary>
    /// <value>Document that matched the query.</value>
    [JsonPropertyName("document")]
    public KnowledgeSearchDocumentResponse Document { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentSearchResult {\n");

        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
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
        return Equals(obj as KnowledgeDocumentSearchResult);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentSearchResult instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentSearchResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentSearchResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
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
            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            return hash;
        }
    }
}
