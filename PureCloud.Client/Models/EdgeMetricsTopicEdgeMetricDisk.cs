using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricDisk
/// </summary>

public partial class EdgeMetricsTopicEdgeMetricDisk : IEquatable<EdgeMetricsTopicEdgeMetricDisk>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricDisk" /> class.
    /// </summary>
    /// <param name="PartitionName">PartitionName.</param>
    /// <param name="AvailableBytes">AvailableBytes.</param>
    /// <param name="TotalBytes">TotalBytes.</param>
    public EdgeMetricsTopicEdgeMetricDisk(string PartitionName = null, long? AvailableBytes = null, long? TotalBytes = null)
    {
        this.PartitionName = PartitionName;
        this.AvailableBytes = AvailableBytes;
        this.TotalBytes = TotalBytes;

    }



    /// <summary>
    /// Gets or Sets PartitionName
    /// </summary>
    [JsonPropertyName("partitionName")]
    public string PartitionName { get; set; }



    /// <summary>
    /// Gets or Sets AvailableBytes
    /// </summary>
    [JsonPropertyName("availableBytes")]
    public long? AvailableBytes { get; set; }



    /// <summary>
    /// Gets or Sets TotalBytes
    /// </summary>
    [JsonPropertyName("totalBytes")]
    public long? TotalBytes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricDisk {\n");

        sb.Append("  PartitionName: ").Append(PartitionName).Append("\n");
        sb.Append("  AvailableBytes: ").Append(AvailableBytes).Append("\n");
        sb.Append("  TotalBytes: ").Append(TotalBytes).Append("\n");
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
        return Equals(obj as EdgeMetricsTopicEdgeMetricDisk);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricDisk instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricDisk to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricDisk other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PartitionName == other.PartitionName ||
                PartitionName != null &&
                PartitionName.Equals(other.PartitionName)
            ) &&
            (
                AvailableBytes == other.AvailableBytes ||
                AvailableBytes != null &&
                AvailableBytes.Equals(other.AvailableBytes)
            ) &&
            (
                TotalBytes == other.TotalBytes ||
                TotalBytes != null &&
                TotalBytes.Equals(other.TotalBytes)
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
            if (PartitionName != null)
            {
                hash = hash * 59 + PartitionName.GetHashCode();
            }

            if (AvailableBytes != null)
            {
                hash = hash * 59 + AvailableBytes.GetHashCode();
            }

            if (TotalBytes != null)
            {
                hash = hash * 59 + TotalBytes.GetHashCode();
            }

            return hash;
        }
    }
}
