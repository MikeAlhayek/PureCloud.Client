using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Article
/// </summary>
[DataContract]
public partial class Article : IEquatable<Article>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Article" /> class.
    /// </summary>
    public Article()
    {

    }



    /// <summary>
    /// The article title.
    /// </summary>
    /// <value>The article title.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; private set; }



    /// <summary>
    /// The URI for the article.
    /// </summary>
    /// <value>The URI for the article.</value>
    [DataMember(Name = "uri", EmitDefaultValue = false)]
    public string Uri { get; private set; }



    /// <summary>
    /// This contains snippets of text from the article matching the query.
    /// </summary>
    /// <value>This contains snippets of text from the article matching the query.</value>
    [DataMember(Name = "snippets", EmitDefaultValue = false)]
    public List<string> Snippets { get; private set; }



    /// <summary>
    /// Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.
    /// </summary>
    /// <value>Value between 0 and 1. 1 corresponds to very confident, 0 to not confident at all.</value>
    [DataMember(Name = "confidence", EmitDefaultValue = false)]
    public float? Confidence { get; private set; }



    /// <summary>
    /// A map that contains custom metadata about the article answer.
    /// </summary>
    /// <value>A map that contains custom metadata about the article answer.</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public Dictionary<string, MetadataAttribute> Metadata { get; private set; }



    /// <summary>
    /// The version of the Article.
    /// </summary>
    /// <value>The version of the Article.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public AddressableEntityRef Version { get; private set; }



    /// <summary>
    /// Variations of the Article.
    /// </summary>
    /// <value>Variations of the Article.</value>
    [DataMember(Name = "variations", EmitDefaultValue = false)]
    public List<AddressableEntityRef> Variations { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Article {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Uri: ").Append(Uri).Append("\n");
        sb.Append("  Snippets: ").Append(Snippets).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as Article);
    }

    /// <summary>
    /// Returns true if Article instances are equal
    /// </summary>
    /// <param name="other">Instance of Article to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Article other)
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
                Uri == other.Uri ||
                Uri != null &&
                Uri.Equals(other.Uri)
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
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.SequenceEqual(other.Metadata)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Uri != null)
            {
                hash = hash * 59 + Uri.GetHashCode();
            }

            if (Snippets != null)
            {
                hash = hash * 59 + Snippets.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Variations != null)
            {
                hash = hash * 59 + Variations.GetHashCode();
            }

            return hash;
        }
    }
}
