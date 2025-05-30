using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAnswerDocumentsResponse
/// </summary>

public partial class KnowledgeAnswerDocumentsResponse : IEquatable<KnowledgeAnswerDocumentsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAnswerDocumentsResponse" /> class.
    /// </summary>
    /// <param name="Results">The results with answers if the answerMode request property is not set or contains \&quot;AnswerHighlight\&quot;. Empty array otherwise..</param>
    /// <param name="AnswerGeneration">The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;..</param>
    public KnowledgeAnswerDocumentsResponse(List<KnowledgeAnswerDocumentResponse> Results = null, KnowledgeAnswerGenerationResponse AnswerGeneration = null)
    {
        this.Results = Results;
        this.AnswerGeneration = AnswerGeneration;

    }



    /// <summary>
    /// The results with answers if the answerMode request property is not set or contains \&quot;AnswerHighlight\&quot;. Empty array otherwise.
    /// </summary>
    /// <value>The results with answers if the answerMode request property is not set or contains \&quot;AnswerHighlight\&quot;. Empty array otherwise.</value>
    [JsonPropertyName("results")]
    public List<KnowledgeAnswerDocumentResponse> Results { get; set; }



    /// <summary>
    /// The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;.
    /// </summary>
    /// <value>The results with AI-generated answer if the answerMode request property contains \&quot;AnswerGeneration\&quot;.</value>
    [JsonPropertyName("answerGeneration")]
    public KnowledgeAnswerGenerationResponse AnswerGeneration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeAnswerDocumentsResponse {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  AnswerGeneration: ").Append(AnswerGeneration).Append("\n");
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
        return Equals(obj as KnowledgeAnswerDocumentsResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeAnswerDocumentsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAnswerDocumentsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAnswerDocumentsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            ) &&
            (
                AnswerGeneration == other.AnswerGeneration ||
                AnswerGeneration != null &&
                AnswerGeneration.Equals(other.AnswerGeneration)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (AnswerGeneration != null)
            {
                hash = hash * 59 + AnswerGeneration.GetHashCode();
            }

            return hash;
        }
    }
}
