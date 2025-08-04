using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsAvailablePhoneNumberEntityListing
/// </summary>

public partial class SmsAvailablePhoneNumberEntityListing : IEquatable<SmsAvailablePhoneNumberEntityListing>, IPagedResource<SmsAvailablePhoneNumber>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsAvailablePhoneNumberEntityListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="PageNumber">PageNumber.</param>
    /// <param name="Total">Total.</param>
    /// <param name="FirstUri">FirstUri.</param>
    /// <param name="LastUri">LastUri.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="NextUri">NextUri.</param>
    /// <param name="PreviousUri">PreviousUri.</param>
    /// <param name="PageCount">PageCount.</param>
    public SmsAvailablePhoneNumberEntityListing(List<SmsAvailablePhoneNumber> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, string FirstUri = null, string LastUri = null, string SelfUri = null, string NextUri = null, string PreviousUri = null, int? PageCount = null)
    {
        this.Entities = Entities;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Total = Total;
        this.FirstUri = FirstUri;
        this.LastUri = LastUri;
        this.SelfUri = SelfUri;
        this.NextUri = NextUri;
        this.PreviousUri = PreviousUri;
        this.PageCount = PageCount;
    }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<SmsAvailablePhoneNumber> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets FirstUri
    /// </summary>
    [JsonPropertyName("firstUri")]
    public string FirstUri { get; set; }

    /// <summary>
    /// Gets or Sets LastUri
    /// </summary>
    [JsonPropertyName("lastUri")]
    public string LastUri { get; set; }

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
    /// Gets or Sets PreviousUri
    /// </summary>
    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((SmsAvailablePhoneNumberEntityListing)obj);
    }

    /// <summary>
    /// Returns true if SmsAvailablePhoneNumberEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsAvailablePhoneNumberEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsAvailablePhoneNumberEntityListing other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
            (
                Entities == other.Entities ||
                Entities != null && other.Entities != null &&
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hashCode = 41;
            // Suitable nullity checks etc, of course :)
            if (Entities != null)
                hashCode = hashCode * 59 + Entities.GetHashCode();
            if (PageSize != null)
                hashCode = hashCode * 59 + PageSize.GetHashCode();
            if (PageNumber != null)
                hashCode = hashCode * 59 + PageNumber.GetHashCode();
            if (Total != null)
                hashCode = hashCode * 59 + Total.GetHashCode();
            if (FirstUri != null)
                hashCode = hashCode * 59 + FirstUri.GetHashCode();
            if (LastUri != null)
                hashCode = hashCode * 59 + LastUri.GetHashCode();
            if (SelfUri != null)
                hashCode = hashCode * 59 + SelfUri.GetHashCode();
            if (NextUri != null)
                hashCode = hashCode * 59 + NextUri.GetHashCode();
            if (PreviousUri != null)
                hashCode = hashCode * 59 + PreviousUri.GetHashCode();
            if (PageCount != null)
                hashCode = hashCode * 59 + PageCount.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }
}