using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentArticle
/// </summary>

public partial class DocumentArticle : IEquatable<DocumentArticle>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentArticle" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentArticle() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentArticle" /> class.
    /// </summary>
    /// <param name="Title">The title of the Article. (required).</param>
    /// <param name="Alternatives">List of Alternative questions related to the title which helps in improving the likelihood of a match to user query..</param>
    public DocumentArticle(string Title = null, List<string> Alternatives = null)
    {
        this.Title = Title;
        this.Alternatives = Alternatives;

    }



    /// <summary>
    /// The title of the Article.
    /// </summary>
    /// <value>The title of the Article.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The content of the Article.
    /// </summary>
    /// <value>The content of the Article.</value>
    [JsonPropertyName("content")]
    public ArticleContent Content { get; set; }



    /// <summary>
    /// List of Alternative questions related to the title which helps in improving the likelihood of a match to user query.
    /// </summary>
    /// <value>List of Alternative questions related to the title which helps in improving the likelihood of a match to user query.</value>
    [JsonPropertyName("alternatives")]
    public List<string> Alternatives { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentArticle {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
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
        return Equals(obj as DocumentArticle);
    }

    /// <summary>
    /// Returns true if DocumentArticle instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentArticle to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentArticle other)
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
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                Alternatives == other.Alternatives ||
                Alternatives != null &&
                Alternatives.SequenceEqual(other.Alternatives)
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

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Alternatives != null)
            {
                hash = hash * 59 + Alternatives.GetHashCode();
            }

            return hash;
        }
    }
}
