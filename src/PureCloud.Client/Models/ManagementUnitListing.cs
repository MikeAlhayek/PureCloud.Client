using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ManagementUnitListing
/// </summary>

public partial class ManagementUnitListing : IEquatable<ManagementUnitListing>, IPagedResource<ManagementUnit>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ManagementUnitListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="PageSize">Deprecated, paging is not supported.</param>
    /// <param name="PageNumber">Deprecated, paging is not supported.</param>
    /// <param name="Total">Deprecated, paging is not supported.</param>
    /// <param name="FirstUri">Deprecated, paging is not supported.</param>
    /// <param name="LastUri">Deprecated, paging is not supported.</param>
    /// <param name="PageCount">Deprecated, paging is not supported.</param>
    /// <param name="NextUri">Deprecated, paging is not supported.</param>
    /// <param name="PreviousUri">Deprecated, paging is not supported.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public ManagementUnitListing(List<ManagementUnit> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, string FirstUri = null, string LastUri = null, int? PageCount = null, string NextUri = null, string PreviousUri = null, string SelfUri = null)
    {
        this.Entities = Entities;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Total = Total;
        this.FirstUri = FirstUri;
        this.LastUri = LastUri;
        this.PageCount = PageCount;
        this.NextUri = NextUri;
        this.PreviousUri = PreviousUri;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ManagementUnit> Entities { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("total")]
    public long? Total { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("firstUri")]
    public string FirstUri { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("lastUri")]
    public string LastUri { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }



    /// <summary>
    /// Deprecated, paging is not supported
    /// </summary>
    /// <value>Deprecated, paging is not supported</value>
    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ManagementUnitListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
        sb.Append("  LastUri: ").Append(LastUri).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
        sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ManagementUnitListing);
    }

    /// <summary>
    /// Returns true if ManagementUnitListing instances are equal
    /// </summary>
    /// <param name="other">Instance of ManagementUnitListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ManagementUnitListing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                FirstUri == other.FirstUri ||
                FirstUri != null &&
                FirstUri.Equals(other.FirstUri)
            ) &&
            (
                LastUri == other.LastUri ||
                LastUri != null &&
                LastUri.Equals(other.LastUri)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            ) &&
            (
                NextUri == other.NextUri ||
                NextUri != null &&
                NextUri.Equals(other.NextUri)
            ) &&
            (
                PreviousUri == other.PreviousUri ||
                PreviousUri != null &&
                PreviousUri.Equals(other.PreviousUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (FirstUri != null)
            {
                hash = hash * 59 + FirstUri.GetHashCode();
            }

            if (LastUri != null)
            {
                hash = hash * 59 + LastUri.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            if (PreviousUri != null)
            {
                hash = hash * 59 + PreviousUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
