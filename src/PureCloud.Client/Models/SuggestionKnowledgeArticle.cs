using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionKnowledgeArticle
/// </summary>

public partial class SuggestionKnowledgeArticle : IEquatable<SuggestionKnowledgeArticle>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionKnowledgeArticle" /> class.
    /// </summary>
    public SuggestionKnowledgeArticle()
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
    /// The article.
    /// </summary>
    /// <value>The article.</value>
    [JsonPropertyName("document")]
    public AddressableEntityRef Document { get; set; }



    /// <summary>
    /// The version of the article.
    /// </summary>
    /// <value>The version of the article.</value>
    [JsonPropertyName("version")]
    public AddressableEntityRef Version { get; set; }



    /// <summary>
    /// The most relevant answer within the suggested article.
    /// </summary>
    /// <value>The most relevant answer within the suggested article.</value>
    [JsonPropertyName("knowledgeAnswer")]
    public SuggestionKnowledgeAnswer KnowledgeAnswer { get; set; }



    /// <summary>
    /// The variations of the article.
    /// </summary>
    /// <value>The variations of the article.</value>
    [JsonPropertyName("variations")]
    public List<AddressableEntityRef> Variations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionKnowledgeArticle {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Snippets: ").Append(Snippets).Append("\n");
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
        return Equals(obj as SuggestionKnowledgeArticle);
    }

    /// <summary>
    /// Returns true if SuggestionKnowledgeArticle instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionKnowledgeArticle to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionKnowledgeArticle other)
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
