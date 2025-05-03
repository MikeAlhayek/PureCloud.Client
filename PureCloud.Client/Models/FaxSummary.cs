using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FaxSummary
/// </summary>

public partial class FaxSummary : IEquatable<FaxSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FaxSummary" /> class.
    /// </summary>
    /// <param name="ReadCount">ReadCount.</param>
    /// <param name="UnreadCount">UnreadCount.</param>
    /// <param name="TotalCount">TotalCount.</param>
    public FaxSummary(int? ReadCount = null, int? UnreadCount = null, int? TotalCount = null)
    {
        this.ReadCount = ReadCount;
        this.UnreadCount = UnreadCount;
        this.TotalCount = TotalCount;

    }



    /// <summary>
    /// Gets or Sets ReadCount
    /// </summary>
    [JsonPropertyName("readCount")]
    public int? ReadCount { get; set; }



    /// <summary>
    /// Gets or Sets UnreadCount
    /// </summary>
    [JsonPropertyName("unreadCount")]
    public int? UnreadCount { get; set; }



    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FaxSummary {\n");

        sb.Append("  ReadCount: ").Append(ReadCount).Append("\n");
        sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
        return Equals(obj as FaxSummary);
    }

    /// <summary>
    /// Returns true if FaxSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of FaxSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FaxSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReadCount == other.ReadCount ||
                ReadCount != null &&
                ReadCount.Equals(other.ReadCount)
            ) &&
            (
                UnreadCount == other.UnreadCount ||
                UnreadCount != null &&
                UnreadCount.Equals(other.UnreadCount)
            ) &&
            (
                TotalCount == other.TotalCount ||
                TotalCount != null &&
                TotalCount.Equals(other.TotalCount)
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
            if (ReadCount != null)
            {
                hash = hash * 59 + ReadCount.GetHashCode();
            }

            if (UnreadCount != null)
            {
                hash = hash * 59 + UnreadCount.GetHashCode();
            }

            if (TotalCount != null)
            {
                hash = hash * 59 + TotalCount.GetHashCode();
            }

            return hash;
        }
    }
}
