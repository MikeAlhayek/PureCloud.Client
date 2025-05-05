using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsDisk
/// </summary>

public partial class EdgeMetricsDisk : IEquatable<EdgeMetricsDisk>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsDisk" /> class.
    /// </summary>
    /// <param name="AvailableBytes">Available memory in bytes..</param>
    /// <param name="PartitionName">Disk partition name..</param>
    /// <param name="TotalBytes">Total memory in bytes..</param>
    public EdgeMetricsDisk(double? AvailableBytes = null, string PartitionName = null, double? TotalBytes = null)
    {
        this.AvailableBytes = AvailableBytes;
        this.PartitionName = PartitionName;
        this.TotalBytes = TotalBytes;

    }



    /// <summary>
    /// Available memory in bytes.
    /// </summary>
    /// <value>Available memory in bytes.</value>
    [JsonPropertyName("availableBytes")]
    public double? AvailableBytes { get; set; }



    /// <summary>
    /// Disk partition name.
    /// </summary>
    /// <value>Disk partition name.</value>
    [JsonPropertyName("partitionName")]
    public string PartitionName { get; set; }



    /// <summary>
    /// Total memory in bytes.
    /// </summary>
    /// <value>Total memory in bytes.</value>
    [JsonPropertyName("totalBytes")]
    public double? TotalBytes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsDisk {\n");

        sb.Append("  AvailableBytes: ").Append(AvailableBytes).Append("\n");
        sb.Append("  PartitionName: ").Append(PartitionName).Append("\n");
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
        return Equals(obj as EdgeMetricsDisk);
    }

    /// <summary>
    /// Returns true if EdgeMetricsDisk instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsDisk to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsDisk other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AvailableBytes == other.AvailableBytes ||
                AvailableBytes != null &&
                AvailableBytes.Equals(other.AvailableBytes)
            ) &&
            (
                PartitionName == other.PartitionName ||
                PartitionName != null &&
                PartitionName.Equals(other.PartitionName)
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
            if (AvailableBytes != null)
            {
                hash = hash * 59 + AvailableBytes.GetHashCode();
            }

            if (PartitionName != null)
            {
                hash = hash * 59 + PartitionName.GetHashCode();
            }

            if (TotalBytes != null)
            {
                hash = hash * 59 + TotalBytes.GetHashCode();
            }

            return hash;
        }
    }
}
