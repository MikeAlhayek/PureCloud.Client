using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAnswerGenerationResponse
/// </summary>

public partial class KnowledgeAnswerGenerationResponse : IEquatable<KnowledgeAnswerGenerationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAnswerGenerationResponse" /> class.
    /// </summary>
    /// <param name="Answer">The AI-generated answer..</param>
    /// <param name="Documents">The documents used for answer generation..</param>
    public KnowledgeAnswerGenerationResponse(string Answer = null, List<AnswerGenerationDocument> Documents = null)
    {
        this.Answer = Answer;
        this.Documents = Documents;

    }



    /// <summary>
    /// The AI-generated answer.
    /// </summary>
    /// <value>The AI-generated answer.</value>
    [JsonPropertyName("answer")]
    public string Answer { get; set; }



    /// <summary>
    /// The documents used for answer generation.
    /// </summary>
    /// <value>The documents used for answer generation.</value>
    [JsonPropertyName("documents")]
    public List<AnswerGenerationDocument> Documents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeAnswerGenerationResponse {\n");

        sb.Append("  Answer: ").Append(Answer).Append("\n");
        sb.Append("  Documents: ").Append(Documents).Append("\n");
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
        return Equals(obj as KnowledgeAnswerGenerationResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeAnswerGenerationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAnswerGenerationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAnswerGenerationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Answer == other.Answer ||
                Answer != null &&
                Answer.Equals(other.Answer)
            ) &&
            (
                Documents == other.Documents ||
                Documents != null &&
                Documents.SequenceEqual(other.Documents)
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
            if (Answer != null)
            {
                hash = hash * 59 + Answer.GetHashCode();
            }

            if (Documents != null)
            {
                hash = hash * 59 + Documents.GetHashCode();
            }

            return hash;
        }
    }
}
