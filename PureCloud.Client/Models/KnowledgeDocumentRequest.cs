using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentRequest
/// </summary>
[DataContract]
public partial class KnowledgeDocumentRequest : IEquatable<KnowledgeDocumentRequest>
{
    /// <summary>
    /// Document type according to assigned template
    /// </summary>
    /// <value>Document type according to assigned template</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Faq for "Faq"
        /// </summary>
        [EnumMember(Value = "Faq")]
        Faq,

        /// <summary>
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article
    }
    /// <summary>
    /// Document type according to assigned template
    /// </summary>
    /// <value>Document type according to assigned template</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentRequest" /> class.
    /// </summary>
    /// <param name="Type">Document type according to assigned template (required).</param>
    /// <param name="ExternalUrl">External Url to the document.</param>
    /// <param name="Faq">Faq document details.</param>
    /// <param name="Categories">Document categories.</param>
    /// <param name="Article">Article details.</param>
    public KnowledgeDocumentRequest(TypeEnum? Type = null, string ExternalUrl = null, DocumentFaq Faq = null, List<DocumentCategoryInput> Categories = null, DocumentArticle Article = null)
    {
        this.Type = Type;
        this.ExternalUrl = ExternalUrl;
        this.Faq = Faq;
        this.Categories = Categories;
        this.Article = Article;

    }





    /// <summary>
    /// External Url to the document
    /// </summary>
    /// <value>External Url to the document</value>
    [DataMember(Name = "externalUrl", EmitDefaultValue = false)]
    public string ExternalUrl { get; set; }



    /// <summary>
    /// Faq document details
    /// </summary>
    /// <value>Faq document details</value>
    [DataMember(Name = "faq", EmitDefaultValue = false)]
    public DocumentFaq Faq { get; set; }



    /// <summary>
    /// Document categories
    /// </summary>
    /// <value>Document categories</value>
    [DataMember(Name = "categories", EmitDefaultValue = false)]
    public List<DocumentCategoryInput> Categories { get; set; }



    /// <summary>
    /// Article details
    /// </summary>
    /// <value>Article details</value>
    [DataMember(Name = "article", EmitDefaultValue = false)]
    public DocumentArticle Article { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
        sb.Append("  Faq: ").Append(Faq).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  Article: ").Append(Article).Append("\n");
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
        return Equals(obj as KnowledgeDocumentRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ExternalUrl == other.ExternalUrl ||
                ExternalUrl != null &&
                ExternalUrl.Equals(other.ExternalUrl)
            ) &&
            (
                Faq == other.Faq ||
                Faq != null &&
                Faq.Equals(other.Faq)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.SequenceEqual(other.Categories)
            ) &&
            (
                Article == other.Article ||
                Article != null &&
                Article.Equals(other.Article)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ExternalUrl != null)
            {
                hash = hash * 59 + ExternalUrl.GetHashCode();
            }

            if (Faq != null)
            {
                hash = hash * 59 + Faq.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            if (Article != null)
            {
                hash = hash * 59 + Article.GetHashCode();
            }

            return hash;
        }
    }
}
