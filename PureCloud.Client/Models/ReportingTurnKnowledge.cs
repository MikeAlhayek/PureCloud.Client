using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnKnowledge
/// </summary>
[DataContract]
public partial class ReportingTurnKnowledge : IEquatable<ReportingTurnKnowledge>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnKnowledge" /> class.
    /// </summary>
    /// <param name="KnowledgeBaseId">The Knowledge Base ID that the captured knowledge data relates to..</param>
    /// <param name="Feedback">The knowledge feedback data that was captured during this reporting turn..</param>
    /// <param name="Search">The knowledge search data that was captured during this reporting turn..</param>
    public ReportingTurnKnowledge(string KnowledgeBaseId = null, ReportingTurnKnowledgeFeedback Feedback = null, ReportingTurnKnowledgeSearch Search = null)
    {
        this.KnowledgeBaseId = KnowledgeBaseId;
        this.Feedback = Feedback;
        this.Search = Search;

    }



    /// <summary>
    /// The Knowledge Base ID that the captured knowledge data relates to.
    /// </summary>
    /// <value>The Knowledge Base ID that the captured knowledge data relates to.</value>
    [DataMember(Name = "knowledgeBaseId", EmitDefaultValue = false)]
    public string KnowledgeBaseId { get; set; }



    /// <summary>
    /// The knowledge feedback data that was captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge feedback data that was captured during this reporting turn.</value>
    [DataMember(Name = "feedback", EmitDefaultValue = false)]
    public ReportingTurnKnowledgeFeedback Feedback { get; set; }



    /// <summary>
    /// The knowledge search data that was captured during this reporting turn.
    /// </summary>
    /// <value>The knowledge search data that was captured during this reporting turn.</value>
    [DataMember(Name = "search", EmitDefaultValue = false)]
    public ReportingTurnKnowledgeSearch Search { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnKnowledge {\n");

        sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
        sb.Append("  Feedback: ").Append(Feedback).Append("\n");
        sb.Append("  Search: ").Append(Search).Append("\n");
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
        return Equals(obj as ReportingTurnKnowledge);
    }

    /// <summary>
    /// Returns true if ReportingTurnKnowledge instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnKnowledge to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnKnowledge other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                KnowledgeBaseId == other.KnowledgeBaseId ||
                KnowledgeBaseId != null &&
                KnowledgeBaseId.Equals(other.KnowledgeBaseId)
            ) &&
            (
                Feedback == other.Feedback ||
                Feedback != null &&
                Feedback.Equals(other.Feedback)
            ) &&
            (
                Search == other.Search ||
                Search != null &&
                Search.Equals(other.Search)
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
            if (KnowledgeBaseId != null)
            {
                hash = hash * 59 + KnowledgeBaseId.GetHashCode();
            }

            if (Feedback != null)
            {
                hash = hash * 59 + Feedback.GetHashCode();
            }

            if (Search != null)
            {
                hash = hash * 59 + Search.GetHashCode();
            }

            return hash;
        }
    }
}
