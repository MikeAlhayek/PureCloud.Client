using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAssetSearchResults
/// </summary>

public partial class ResponseAssetSearchResults : IEquatable<ResponseAssetSearchResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseAssetSearchResults" /> class.
    /// </summary>
    /// <param name="Total">The total number of results found.</param>
    /// <param name="PageCount">The total number of pages.</param>
    /// <param name="PageSize">The current page size.</param>
    /// <param name="PageNumber">The current page number.</param>
    /// <param name="Results">Search results.</param>
    public ResponseAssetSearchResults(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, List<ResponseAsset> Results = null)
    {
        this.Total = Total;
        this.PageCount = PageCount;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Results = Results;

    }



    /// <summary>
    /// The total number of results found
    /// </summary>
    /// <value>The total number of results found</value>
    [JsonPropertyName("total")]
    public long? Total { get; set; }



    /// <summary>
    /// The total number of pages
    /// </summary>
    /// <value>The total number of pages</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }



    /// <summary>
    /// The current page size
    /// </summary>
    /// <value>The current page size</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// The current page number
    /// </summary>
    /// <value>The current page number</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Search results
    /// </summary>
    /// <value>Search results</value>
    [JsonPropertyName("results")]
    public List<ResponseAsset> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseAssetSearchResults {\n");

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
        return Equals(obj as ResponseAssetSearchResults);
    }

    /// <summary>
    /// Returns true if ResponseAssetSearchResults instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseAssetSearchResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseAssetSearchResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
