using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnKnowledgeFeedback
/// </summary>

public partial class ReportingTurnKnowledgeFeedback : IEquatable<ReportingTurnKnowledgeFeedback>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeFeedback" /> class.
    /// </summary>
    /// <param name="SearchId">The ID of the original knowledge search that this feedback relates to..</param>
    /// <param name="Rating">The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive..</param>
    /// <param name="Documents">The list of search documents that the feedback applies to..</param>
    public ReportingTurnKnowledgeFeedback(string SearchId = null, int? Rating = null, List<ReportingTurnKnowledgeDocument> Documents = null)
    {
        this.SearchId = SearchId;
        this.Rating = Rating;
        this.Documents = Documents;

    }



    /// <summary>
    /// The ID of the original knowledge search that this feedback relates to.
    /// </summary>
    /// <value>The ID of the original knowledge search that this feedback relates to.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.
    /// </summary>
    /// <value>The feedback rating for the search (1.0 - 5.0). 1 &#x3D; Negative, 5 &#x3D; Positive.</value>
    [JsonPropertyName("rating")]
    public int? Rating { get; set; }



    /// <summary>
    /// The list of search documents that the feedback applies to.
    /// </summary>
    /// <value>The list of search documents that the feedback applies to.</value>
    [JsonPropertyName("documents")]
    public List<ReportingTurnKnowledgeDocument> Documents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnKnowledgeFeedback {\n");

        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Rating: ").Append(Rating).Append("\n");
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
        return Equals(obj as ReportingTurnKnowledgeFeedback);
    }

    /// <summary>
    /// Returns true if ReportingTurnKnowledgeFeedback instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnKnowledgeFeedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnKnowledgeFeedback other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                Rating == other.Rating ||
                Rating != null &&
                Rating.Equals(other.Rating)
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
            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (Rating != null)
            {
                hash = hash * 59 + Rating.GetHashCode();
            }

            if (Documents != null)
            {
                hash = hash * 59 + Documents.GetHashCode();
            }

            return hash;
        }
    }
}
