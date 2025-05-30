using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSearchResponse
/// </summary>

public partial class KnowledgeSearchResponse : IEquatable<KnowledgeSearchResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSearchResponse" /> class.
    /// </summary>
    public KnowledgeSearchResponse()
    {

    }



    /// <summary>
    /// Search Id
    /// </summary>
    /// <value>Search Id</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// Total number of records returned
    /// </summary>
    /// <value>Total number of records returned</value>
    [JsonPropertyName("total")]
    public int? Total { get; set; }



    /// <summary>
    /// Number of pages returned in the result calculated according to the pageSize and the total
    /// </summary>
    /// <value>Number of pages returned in the result calculated according to the pageSize and the total</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }



    /// <summary>
    /// Number of records according to the page size
    /// </summary>
    /// <value>Number of records according to the page size</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Current page number for the returned records
    /// </summary>
    /// <value>Current page number for the returned records</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Results associated to the search response
    /// </summary>
    /// <value>Results associated to the search response</value>
    [JsonPropertyName("results")]
    public List<KnowledgeSearchDocumentV1> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSearchResponse {\n");

        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
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
        return Equals(obj as KnowledgeSearchResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSearchResponse other)
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
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
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
            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
