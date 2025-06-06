using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SegmentEstimateCount
/// </summary>

public partial class SegmentEstimateCount : IEquatable<SegmentEstimateCount>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SegmentEstimateCount" /> class.
    /// </summary>
    /// <param name="SegmentId">ID of Segment..</param>
    /// <param name="Count">Estimate count per segment..</param>
    public SegmentEstimateCount(string SegmentId = null, int? Count = null)
    {
        this.SegmentId = SegmentId;
        this.Count = Count;

    }



    /// <summary>
    /// ID of Segment.
    /// </summary>
    /// <value>ID of Segment.</value>
    [JsonPropertyName("segmentId")]
    public string SegmentId { get; set; }



    /// <summary>
    /// Estimate count per segment.
    /// </summary>
    /// <value>Estimate count per segment.</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SegmentEstimateCount {\n");

        sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as SegmentEstimateCount);
    }

    /// <summary>
    /// Returns true if SegmentEstimateCount instances are equal
    /// </summary>
    /// <param name="other">Instance of SegmentEstimateCount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SegmentEstimateCount other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SegmentId == other.SegmentId ||
                SegmentId != null &&
                SegmentId.Equals(other.SegmentId)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (SegmentId != null)
            {
                hash = hash * 59 + SegmentId.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
