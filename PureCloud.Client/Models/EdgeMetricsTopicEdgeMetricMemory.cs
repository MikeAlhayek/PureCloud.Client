using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricMemory
/// </summary>
[DataContract]
public partial class EdgeMetricsTopicEdgeMetricMemory : IEquatable<EdgeMetricsTopicEdgeMetricMemory>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricMemory" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="AvailableBytes">AvailableBytes.</param>
    /// <param name="TotalBytes">TotalBytes.</param>
    public EdgeMetricsTopicEdgeMetricMemory(string Type = null, long? AvailableBytes = null, long? TotalBytes = null)
    {
        this.Type = Type;
        this.AvailableBytes = AvailableBytes;
        this.TotalBytes = TotalBytes;

    }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets AvailableBytes
    /// </summary>
    [DataMember(Name = "availableBytes", EmitDefaultValue = false)]
    public long? AvailableBytes { get; set; }



    /// <summary>
    /// Gets or Sets TotalBytes
    /// </summary>
    [DataMember(Name = "totalBytes", EmitDefaultValue = false)]
    public long? TotalBytes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricMemory {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as EdgeMetricsTopicEdgeMetricMemory);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricMemory instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricMemory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricMemory other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
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
