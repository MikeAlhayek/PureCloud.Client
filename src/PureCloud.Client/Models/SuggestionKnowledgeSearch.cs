using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionKnowledgeSearch
/// </summary>

public partial class SuggestionKnowledgeSearch : IEquatable<SuggestionKnowledgeSearch>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionKnowledgeSearch" /> class.
    /// </summary>
    public SuggestionKnowledgeSearch()
    {

    }



    /// <summary>
    /// The article title.
    /// </summary>
    /// <value>The article title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Snippets of text from the article matching the query.
    /// </summary>
    /// <value>Snippets of text from the article matching the query.</value>
    [JsonPropertyName("snippets")]
    public List<string> Snippets { get; set; }



    /// <summary>
    /// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.
    /// </summary>
    /// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.</value>
    [JsonPropertyName("confidence")]
    public float? Confidence { get; set; }



    /// <summary>
    /// The search id.
    /// </summary>
    /// <value>The search id.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// The article matching the query.
    /// </summary>
    /// <value>The article matching the query.</value>
    [JsonPropertyName("document")]
    public AddressableEntityRef Document { get; set; }



    /// <summary>
    /// The version of the article.
    /// </summary>
    /// <value>The version of the article.</value>
    [JsonPropertyName("version")]
    public AddressableEntityRef Version { get; set; }



    /// <summary>
    /// The most relevant answer within a searched article for the searched query
    /// </summary>
    /// <value>The most relevant answer within a searched article for the searched query</value>
    [JsonPropertyName("knowledgeAnswer")]
    public SuggestionKnowledgeAnswer KnowledgeAnswer { get; set; }



    /// <summary>
    /// Variations of the article.
    /// </summary>
    /// <value>Variations of the article.</value>
    [JsonPropertyName("variations")]
    public List<AddressableEntityRef> Variations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionKnowledgeSearch {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Snippets: ").Append(Snippets).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  KnowledgeAnswer: ").Append(KnowledgeAnswer).Append("\n");
        sb.Append("  Variations: ").Append(Variations).Append("\n");
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
        return Equals(obj as SuggestionKnowledgeSearch);
    }

    /// <summary>
    /// Returns true if SuggestionKnowledgeSearch instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionKnowledgeSearch to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionKnowledgeSearch other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Snippets == other.Snippets ||
                Snippets != null &&
                Snippets.SequenceEqual(other.Snippets)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
            ) &&
            (
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                KnowledgeAnswer == other.KnowledgeAnswer ||
                KnowledgeAnswer != null &&
                KnowledgeAnswer.Equals(other.KnowledgeAnswer)
            ) &&
            (
                Variations == other.Variations ||
                Variations != null &&
                Variations.SequenceEqual(other.Variations)
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
            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Snippets != null)
            {
                hash = hash * 59 + Snippets.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (KnowledgeAnswer != null)
            {
                hash = hash * 59 + KnowledgeAnswer.GetHashCode();
            }

            if (Variations != null)
            {
                hash = hash * 59 + Variations.GetHashCode();
            }

            return hash;
        }
    }
}
