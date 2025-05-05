using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnKnowledgeSearch
/// </summary>

public partial class ReportingTurnKnowledgeSearch : IEquatable<ReportingTurnKnowledgeSearch>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnKnowledgeSearch" /> class.
    /// </summary>
    /// <param name="SearchId">The ID of this knowledge search..</param>
    /// <param name="Documents">The list of search documents captured during this reporting turn..</param>
    /// <param name="Query">The search query that was used to search the Knowledge Base documents for a matching question..</param>
    public ReportingTurnKnowledgeSearch(string SearchId = null, List<ReportingTurnKnowledgeDocument> Documents = null, string Query = null)
    {
        this.SearchId = SearchId;
        this.Documents = Documents;
        this.Query = Query;

    }



    /// <summary>
    /// The ID of this knowledge search.
    /// </summary>
    /// <value>The ID of this knowledge search.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// The list of search documents captured during this reporting turn.
    /// </summary>
    /// <value>The list of search documents captured during this reporting turn.</value>
    [JsonPropertyName("documents")]
    public List<ReportingTurnKnowledgeDocument> Documents { get; set; }



    /// <summary>
    /// The search query that was used to search the Knowledge Base documents for a matching question.
    /// </summary>
    /// <value>The search query that was used to search the Knowledge Base documents for a matching question.</value>
    [JsonPropertyName("query")]
    public string Query { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnKnowledgeSearch {\n");

        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Documents: ").Append(Documents).Append("\n");
        sb.Append("  Query: ").Append(Query).Append("\n");
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
        return Equals(obj as ReportingTurnKnowledgeSearch);
    }

    /// <summary>
    /// Returns true if ReportingTurnKnowledgeSearch instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnKnowledgeSearch to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnKnowledgeSearch other)
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
                Documents == other.Documents ||
                Documents != null &&
                Documents.SequenceEqual(other.Documents)
            ) &&
            (
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query)
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

            if (Documents != null)
            {
                hash = hash * 59 + Documents.GetHashCode();
            }

            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            return hash;
        }
    }
}
