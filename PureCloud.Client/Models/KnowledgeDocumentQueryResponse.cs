using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentQueryResponse
/// </summary>
[DataContract]
public partial class KnowledgeDocumentQueryResponse : IEquatable<KnowledgeDocumentQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentQueryResponse" /> class.
    /// </summary>
    /// <param name="PageSize">Page size of the returned results..</param>
    /// <param name="PageNumber">Page number of the returned results..</param>
    public KnowledgeDocumentQueryResponse(int? PageSize = null, int? PageNumber = null)
    {
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;

    }



    /// <summary>
    /// Page size of the returned results.
    /// </summary>
    /// <value>Page size of the returned results.</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Page number of the returned results.
    /// </summary>
    /// <value>Page number of the returned results.</value>
    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }



    /// <summary>
    /// The total number of documents matching the query.
    /// </summary>
    /// <value>The total number of documents matching the query.</value>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; private set; }



    /// <summary>
    /// The total number of pages of results, calculated according to the pageSize and the total matching documents.
    /// </summary>
    /// <value>The total number of pages of results, calculated according to the pageSize and the total matching documents.</value>
    [DataMember(Name = "pageCount", EmitDefaultValue = false)]
    public int? PageCount { get; private set; }



    /// <summary>
    /// Documents matching the query.
    /// </summary>
    /// <value>Documents matching the query.</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<KnowledgeDocumentResponse> Results { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentQueryResponse {\n");

        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
        return this.Equals(obj as KnowledgeDocumentQueryResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.PageSize == other.PageSize ||
                this.PageSize != null &&
                this.PageSize.Equals(other.PageSize)
            ) &&
            (
                this.PageNumber == other.PageNumber ||
                this.PageNumber != null &&
                this.PageNumber.Equals(other.PageNumber)
            ) &&
            (
                this.Total == other.Total ||
                this.Total != null &&
                this.Total.Equals(other.Total)
            ) &&
            (
                this.PageCount == other.PageCount ||
                this.PageCount != null &&
                this.PageCount.Equals(other.PageCount)
            ) &&
            (
                this.Results == other.Results ||
                this.Results != null &&
                this.Results.SequenceEqual(other.Results)
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
            if (this.PageSize != null)
            {
                hash = hash * 59 + this.PageSize.GetHashCode();
            }

            if (this.PageNumber != null)
            {
                hash = hash * 59 + this.PageNumber.GetHashCode();
            }

            if (this.Total != null)
            {
                hash = hash * 59 + this.Total.GetHashCode();
            }

            if (this.PageCount != null)
            {
                hash = hash * 59 + this.PageCount.GetHashCode();
            }

            if (this.Results != null)
            {
                hash = hash * 59 + this.Results.GetHashCode();
            }

            return hash;
        }
    }
}
