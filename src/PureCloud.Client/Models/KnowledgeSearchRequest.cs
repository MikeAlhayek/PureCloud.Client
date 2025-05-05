using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSearchRequest
/// </summary>

public partial class KnowledgeSearchRequest : IEquatable<KnowledgeSearchRequest>
{
    /// <summary>
    /// Document type to be used while searching
    /// </summary>
    /// <value>Document type to be used while searching</value>
    
    public enum DocumentTypeEnum
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
    /// Document type to be used while searching
    /// </summary>
    /// <value>Document type to be used while searching</value>
    [JsonPropertyName("documentType")]
    public DocumentTypeEnum? DocumentType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSearchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeSearchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSearchRequest" /> class.
    /// </summary>
    /// <param name="Query">Input query to search content in the knowledge base (required).</param>
    /// <param name="PageSize">Page size of the returned results.</param>
    /// <param name="PageNumber">Page number of the returned results.</param>
    /// <param name="DocumentType">Document type to be used while searching.</param>
    /// <param name="LanguageCode">query search for specific languageCode (required).</param>
    /// <param name="SearchOnDraftDocuments">If true the search query will be executed on draft documents, else it will be on active documents.</param>
    public KnowledgeSearchRequest(string Query = null, int? PageSize = null, int? PageNumber = null, DocumentTypeEnum? DocumentType = null, string LanguageCode = null, bool? SearchOnDraftDocuments = null)
    {
        this.Query = Query;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.DocumentType = DocumentType;
        this.LanguageCode = LanguageCode;
        this.SearchOnDraftDocuments = SearchOnDraftDocuments;

    }



    /// <summary>
    /// Input query to search content in the knowledge base
    /// </summary>
    /// <value>Input query to search content in the knowledge base</value>
    [JsonPropertyName("query")]
    public string Query { get; set; }



    /// <summary>
    /// Page size of the returned results
    /// </summary>
    /// <value>Page size of the returned results</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Page number of the returned results
    /// </summary>
    /// <value>Page number of the returned results</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }





    /// <summary>
    /// query search for specific languageCode
    /// </summary>
    /// <value>query search for specific languageCode</value>
    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; set; }



    /// <summary>
    /// If true the search query will be executed on draft documents, else it will be on active documents
    /// </summary>
    /// <value>If true the search query will be executed on draft documents, else it will be on active documents</value>
    [JsonPropertyName("searchOnDraftDocuments")]
    public bool? SearchOnDraftDocuments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSearchRequest {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
        sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
        sb.Append("  SearchOnDraftDocuments: ").Append(SearchOnDraftDocuments).Append("\n");
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
        return Equals(obj as KnowledgeSearchRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeSearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSearchRequest other)
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
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                DocumentType == other.DocumentType ||
                DocumentType != null &&
                DocumentType.Equals(other.DocumentType)
            ) &&
            (
                LanguageCode == other.LanguageCode ||
                LanguageCode != null &&
                LanguageCode.Equals(other.LanguageCode)
            ) &&
            (
                SearchOnDraftDocuments == other.SearchOnDraftDocuments ||
                SearchOnDraftDocuments != null &&
                SearchOnDraftDocuments.Equals(other.SearchOnDraftDocuments)
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

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (DocumentType != null)
            {
                hash = hash * 59 + DocumentType.GetHashCode();
            }

            if (LanguageCode != null)
            {
                hash = hash * 59 + LanguageCode.GetHashCode();
            }

            if (SearchOnDraftDocuments != null)
            {
                hash = hash * 59 + SearchOnDraftDocuments.GetHashCode();
            }

            return hash;
        }
    }
}
