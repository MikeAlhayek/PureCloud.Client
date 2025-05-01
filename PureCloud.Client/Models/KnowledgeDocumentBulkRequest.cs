using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentBulkRequest
/// </summary>
[DataContract]
public partial class KnowledgeDocumentBulkRequest : IEquatable<KnowledgeDocumentBulkRequest>
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
    /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentBulkRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkRequest" /> class.
    /// </summary>
    /// <param name="Type">Document type according to assigned template (required).</param>
    /// <param name="ExternalUrl">External Url to the document.</param>
    /// <param name="Faq">Faq document details.</param>
    /// <param name="Categories">Document categories.</param>
    /// <param name="Article">Article details.</param>
    /// <param name="Id">Identifier of document for update. Omit for create new Document..</param>
    public KnowledgeDocumentBulkRequest(TypeEnum? Type = null, string ExternalUrl = null, DocumentFaq Faq = null, List<DocumentCategoryInput> Categories = null, DocumentArticle Article = null, string Id = null)
    {
        this.Type = Type;
        this.ExternalUrl = ExternalUrl;
        this.Faq = Faq;
        this.Categories = Categories;
        this.Article = Article;
        this.Id = Id;

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
    /// Identifier of document for update. Omit for create new Document.
    /// </summary>
    /// <value>Identifier of document for update. Omit for create new Document.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentBulkRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
        sb.Append("  Faq: ").Append(Faq).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  Article: ").Append(Article).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return this.Equals(obj as KnowledgeDocumentBulkRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentBulkRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentBulkRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentBulkRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.ExternalUrl == other.ExternalUrl ||
                this.ExternalUrl != null &&
                this.ExternalUrl.Equals(other.ExternalUrl)
            ) &&
            (
                this.Faq == other.Faq ||
                this.Faq != null &&
                this.Faq.Equals(other.Faq)
            ) &&
            (
                this.Categories == other.Categories ||
                this.Categories != null &&
                this.Categories.SequenceEqual(other.Categories)
            ) &&
            (
                this.Article == other.Article ||
                this.Article != null &&
                this.Article.Equals(other.Article)
            ) &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.ExternalUrl != null)
            {
                hash = hash * 59 + this.ExternalUrl.GetHashCode();
            }

            if (this.Faq != null)
            {
                hash = hash * 59 + this.Faq.GetHashCode();
            }

            if (this.Categories != null)
            {
                hash = hash * 59 + this.Categories.GetHashCode();
            }

            if (this.Article != null)
            {
                hash = hash * 59 + this.Article.GetHashCode();
            }

            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            return hash;
        }
    }
}
