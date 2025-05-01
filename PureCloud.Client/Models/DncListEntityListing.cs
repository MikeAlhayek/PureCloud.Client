using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DncListEntityListing
/// </summary>
[DataContract]
public partial class DncListEntityListing : IEquatable<DncListEntityListing>, IPagedResource<DncList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DncListEntityListing" /> class.
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
    public DncListEntityListing(List<DncList> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, string FirstUri = null, string LastUri = null, string SelfUri = null, string NextUri = null, string PreviousUri = null, int? PageCount = null)
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
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<DncList> Entities { get; set; }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; set; }



    /// <summary>
    /// Gets or Sets FirstUri
    /// </summary>
    [DataMember(Name = "firstUri", EmitDefaultValue = false)]
    public string FirstUri { get; set; }



    /// <summary>
    /// Gets or Sets LastUri
    /// </summary>
    [DataMember(Name = "lastUri", EmitDefaultValue = false)]
    public string LastUri { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [DataMember(Name = "nextUri", EmitDefaultValue = false)]
    public string NextUri { get; set; }



    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    [DataMember(Name = "previousUri", EmitDefaultValue = false)]
    public string PreviousUri { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [DataMember(Name = "pageCount", EmitDefaultValue = false)]
    public int? PageCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DncListEntityListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
        sb.Append("  LastUri: ").Append(LastUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
        sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
        return Equals(obj as DncListEntityListing);
    }

    /// <summary>
    /// Returns true if DncListEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of DncListEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DncListEntityListing other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            if (PreviousUri != null)
            {
                hash = hash * 59 + PreviousUri.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            return hash;
        }
    }
}
