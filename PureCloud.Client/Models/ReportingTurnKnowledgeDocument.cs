using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnKnowledgeDocument
/// </summary>

public partial class ReportingTurnKnowledgeDocument : IEquatable<ReportingTurnKnowledgeDocument>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeDocument" /> class.
    /// </summary>
    /// <param name="Id">The ID of the knowledge document..</param>
    /// <param name="Question">The the question that was used to match against the search query..</param>
    /// <param name="Answer">The corresponding answer to the question..</param>
    /// <param name="Confidence">The confidence score of how well the question matched the search query..</param>
    public ReportingTurnKnowledgeDocument(string Id = null, string Question = null, string Answer = null, double? Confidence = null)
    {
        this.Id = Id;
        this.Question = Question;
        this.Answer = Answer;
        this.Confidence = Confidence;

    }



    /// <summary>
    /// The ID of the knowledge document.
    /// </summary>
    /// <value>The ID of the knowledge document.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The the question that was used to match against the search query.
    /// </summary>
    /// <value>The the question that was used to match against the search query.</value>
    [JsonPropertyName("question")]
    public string Question { get; set; }



    /// <summary>
    /// The corresponding answer to the question.
    /// </summary>
    /// <value>The corresponding answer to the question.</value>
    [JsonPropertyName("answer")]
    public string Answer { get; set; }



    /// <summary>
    /// The confidence score of how well the question matched the search query.
    /// </summary>
    /// <value>The confidence score of how well the question matched the search query.</value>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnKnowledgeDocument {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Question: ").Append(Question).Append("\n");
        sb.Append("  Answer: ").Append(Answer).Append("\n");
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
        return Equals(obj as ReportingTurnKnowledgeDocument);
    }

    /// <summary>
    /// Returns true if ReportingTurnKnowledgeDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnKnowledgeDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnKnowledgeDocument other)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Question != null)
            {
                hash = hash * 59 + Question.GetHashCode();
            }

            if (Answer != null)
            {
                hash = hash * 59 + Answer.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}
