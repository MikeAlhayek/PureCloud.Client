using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DictionaryFeedbackEntityListing
/// </summary>

public partial class DictionaryFeedbackEntityListing : IEquatable<DictionaryFeedbackEntityListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryFeedbackEntityListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="PageCount">PageCount.</param>
    /// <param name="Total">Total.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="NextUri">NextUri.</param>
    public DictionaryFeedbackEntityListing(List<ListedDictionaryFeedback> Entities = null, int? PageSize = null, int? PageCount = null, int? Total = null, string SelfUri = null, string NextUri = null)
    {
        this.Entities = Entities;
        this.PageSize = PageSize;
        this.PageCount = PageCount;
        this.Total = Total;
        this.SelfUri = SelfUri;
        this.NextUri = NextUri;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ListedDictionaryFeedback> Entities { get; set; }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DictionaryFeedbackEntityListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
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
        return Equals(obj as DictionaryFeedbackEntityListing);
    }

    /// <summary>
    /// Returns true if DictionaryFeedbackEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of DictionaryFeedbackEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DictionaryFeedbackEntityListing other)
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
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                NextUri == other.NextUri ||
                NextUri != null &&
                NextUri.Equals(other.NextUri)
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

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            return hash;
        }
    }
}
