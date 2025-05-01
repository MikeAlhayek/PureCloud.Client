using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestDocumentSuggestion
/// </summary>
[DataContract]
public partial class KnowledgeGuestDocumentSuggestion : IEquatable<KnowledgeGuestDocumentSuggestion>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestDocumentSuggestion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeGuestDocumentSuggestion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestDocumentSuggestion" /> class.
    /// </summary>
    /// <param name="Query">Query to get autocomplete suggestions for the matching knowledge documents. (required).</param>
    /// <param name="PageSize">Page size of the returned results..</param>
    public KnowledgeGuestDocumentSuggestion(string Query = null, int? PageSize = null)
    {
        this.Query = Query;
        this.PageSize = PageSize;

    }



    /// <summary>
    /// Query to get autocomplete suggestions for the matching knowledge documents.
    /// </summary>
    /// <value>Query to get autocomplete suggestions for the matching knowledge documents.</value>
    [DataMember(Name = "query", EmitDefaultValue = false)]
    public string Query { get; set; }



    /// <summary>
    /// Page size of the returned results.
    /// </summary>
    /// <value>Page size of the returned results.</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Session ID of the guest suggestions.
    /// </summary>
    /// <value>Session ID of the guest suggestions.</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; private set; }



    /// <summary>
    /// Suggestions matching the query.
    /// </summary>
    /// <value>Suggestions matching the query.</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<KnowledgeGuestDocumentSuggestionResult> Results { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestDocumentSuggestion {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as KnowledgeGuestDocumentSuggestion);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestDocumentSuggestion instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestDocumentSuggestion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestDocumentSuggestion other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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
            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
