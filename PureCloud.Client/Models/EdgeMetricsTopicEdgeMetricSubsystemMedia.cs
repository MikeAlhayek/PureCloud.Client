using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricSubsystemMedia
/// </summary>
[DataContract]
public partial class EdgeMetricsTopicEdgeMetricSubsystemMedia : IEquatable<EdgeMetricsTopicEdgeMetricSubsystemMedia>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricSubsystemMedia" /> class.
    /// </summary>
    /// <param name="ProcessName">ProcessName.</param>
    /// <param name="DelayMs">DelayMs.</param>
    public EdgeMetricsTopicEdgeMetricSubsystemMedia(string ProcessName = null, long? DelayMs = null)
    {
        this.ProcessName = ProcessName;
        this.DelayMs = DelayMs;

    }



    /// <summary>
    /// Gets or Sets ProcessName
    /// </summary>
    [DataMember(Name = "processName", EmitDefaultValue = false)]
    public string ProcessName { get; set; }



    /// <summary>
    /// Gets or Sets DelayMs
    /// </summary>
    [DataMember(Name = "delayMs", EmitDefaultValue = false)]
    public long? DelayMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricSubsystemMedia {\n");

        sb.Append("  ProcessName: ").Append(ProcessName).Append("\n");
        sb.Append("  DelayMs: ").Append(DelayMs).Append("\n");
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
        return this.Equals(obj as EdgeMetricsTopicEdgeMetricSubsystemMedia);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricSubsystemMedia instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricSubsystemMedia to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricSubsystemMedia other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.ProcessName == other.ProcessName ||
                this.ProcessName != null &&
                this.ProcessName.Equals(other.ProcessName)
            ) &&
            (
                this.DelayMs == other.DelayMs ||
                this.DelayMs != null &&
                this.DelayMs.Equals(other.DelayMs)
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
            if (this.ProcessName != null)
            {
                hash = hash * 59 + this.ProcessName.GetHashCode();
            }

            if (this.DelayMs != null)
            {
                hash = hash * 59 + this.DelayMs.GetHashCode();
            }

            return hash;
        }
    }
}
