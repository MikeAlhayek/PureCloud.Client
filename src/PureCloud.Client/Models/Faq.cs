using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Faq
/// </summary>

public partial class Faq : IEquatable<Faq>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Faq" /> class.
    /// </summary>
    public Faq()
    {

    }



    /// <summary>
    /// Question from the knowledge base that was matched to user request.
    /// </summary>
    /// <value>Question from the knowledge base that was matched to user request.</value>
    [JsonPropertyName("question")]
    public string Question { get; set; }



    /// <summary>
    /// Answer from the knowledge base corresponding to the identified question.
    /// </summary>
    /// <value>Answer from the knowledge base corresponding to the identified question.</value>
    [JsonPropertyName("answer")]
    public string Answer { get; set; }



    /// <summary>
    /// A URI uniquely identifying the document, e.g. projects/acme-inc/knowledgeBases/MTAyNjgxNDU1Nzc3NTM1NzU0MjQ/documents/MTI5ODc3NzQzOTQ5MTc5NzgxMTI.
    /// </summary>
    /// <value>A URI uniquely identifying the document, e.g. projects/acme-inc/knowledgeBases/MTAyNjgxNDU1Nzc3NTM1NzU0MjQ/documents/MTI5ODc3NzQzOTQ5MTc5NzgxMTI.</value>
    [JsonPropertyName("sourceUri")]
    public string SourceUri { get; set; }



    /// <summary>
    /// URL pointing to a web page if document was sourced from a URL.
    /// </summary>
    /// <value>URL pointing to a web page if document was sourced from a URL.</value>
    [JsonPropertyName("documentUrl")]
    public string DocumentUrl { get; set; }



    /// <summary>
    /// A human-readable description of the document, e.g. &#39;Sample store FAQ&#39;
    /// </summary>
    /// <value>A human-readable description of the document, e.g. &#39;Sample store FAQ&#39;</value>
    [JsonPropertyName("documentDisplayName")]
    public string DocumentDisplayName { get; set; }



    /// <summary>
    /// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all
    /// </summary>
    /// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all</value>
    [JsonPropertyName("confidence")]
    public float? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Faq {\n");

        sb.Append("  Question: ").Append(Question).Append("\n");
        sb.Append("  Answer: ").Append(Answer).Append("\n");
        sb.Append("  SourceUri: ").Append(SourceUri).Append("\n");
        sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
        sb.Append("  DocumentDisplayName: ").Append(DocumentDisplayName).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
        return Equals(obj as Faq);
    }

    /// <summary>
    /// Returns true if Faq instances are equal
    /// </summary>
    /// <param name="other">Instance of Faq to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Faq other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Question == other.Question ||
                Question != null &&
                Question.Equals(other.Question)
            ) &&
            (
                Answer == other.Answer ||
                Answer != null &&
                Answer.Equals(other.Answer)
            ) &&
            (
                SourceUri == other.SourceUri ||
                SourceUri != null &&
                SourceUri.Equals(other.SourceUri)
            ) &&
            (
                DocumentUrl == other.DocumentUrl ||
                DocumentUrl != null &&
                DocumentUrl.Equals(other.DocumentUrl)
            ) &&
            (
                DocumentDisplayName == other.DocumentDisplayName ||
                DocumentDisplayName != null &&
                DocumentDisplayName.Equals(other.DocumentDisplayName)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
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
            if (Question != null)
            {
                hash = hash * 59 + Question.GetHashCode();
            }

            if (Answer != null)
            {
                hash = hash * 59 + Answer.GetHashCode();
            }

            if (SourceUri != null)
            {
                hash = hash * 59 + SourceUri.GetHashCode();
            }

            if (DocumentUrl != null)
            {
                hash = hash * 59 + DocumentUrl.GetHashCode();
            }

            if (DocumentDisplayName != null)
            {
                hash = hash * 59 + DocumentDisplayName.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}
