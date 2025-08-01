using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentActivityEntityListing
/// </summary>
public sealed class AgentActivityEntityListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<AgentActivity> Entities { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentActivityEntityListing {\n");

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
        return Equals(obj as AgentActivityEntityListing);
    }

    /// <summary>
    /// Returns true if AgentActivityEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentActivityEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentActivityEntityListing other)
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
