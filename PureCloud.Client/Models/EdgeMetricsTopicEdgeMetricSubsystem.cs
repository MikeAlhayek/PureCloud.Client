using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricSubsystem
/// </summary>

public partial class EdgeMetricsTopicEdgeMetricSubsystem : IEquatable<EdgeMetricsTopicEdgeMetricSubsystem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricSubsystem" /> class.
    /// </summary>
    /// <param name="ProcessName">ProcessName.</param>
    /// <param name="DelayMs">DelayMs.</param>
    /// <param name="MediaSubsystem">MediaSubsystem.</param>
    public EdgeMetricsTopicEdgeMetricSubsystem(string ProcessName = null, long? DelayMs = null, EdgeMetricsTopicEdgeMetricSubsystemMedia MediaSubsystem = null)
    {
        this.ProcessName = ProcessName;
        this.DelayMs = DelayMs;
        this.MediaSubsystem = MediaSubsystem;

    }



    /// <summary>
    /// Gets or Sets ProcessName
    /// </summary>
    [JsonPropertyName("processName")]
    public string ProcessName { get; set; }



    /// <summary>
    /// Gets or Sets DelayMs
    /// </summary>
    [JsonPropertyName("delayMs")]
    public long? DelayMs { get; set; }



    /// <summary>
    /// Gets or Sets MediaSubsystem
    /// </summary>
    [JsonPropertyName("mediaSubsystem")]
    public EdgeMetricsTopicEdgeMetricSubsystemMedia MediaSubsystem { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricSubsystem {\n");

        sb.Append("  ProcessName: ").Append(ProcessName).Append("\n");
        sb.Append("  DelayMs: ").Append(DelayMs).Append("\n");
        sb.Append("  MediaSubsystem: ").Append(MediaSubsystem).Append("\n");
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
        return Equals(obj as EdgeMetricsTopicEdgeMetricSubsystem);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricSubsystem instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricSubsystem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricSubsystem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ProcessName == other.ProcessName ||
                ProcessName != null &&
                ProcessName.Equals(other.ProcessName)
            ) &&
            (
                DelayMs == other.DelayMs ||
                DelayMs != null &&
                DelayMs.Equals(other.DelayMs)
            ) &&
            (
                MediaSubsystem == other.MediaSubsystem ||
                MediaSubsystem != null &&
                MediaSubsystem.Equals(other.MediaSubsystem)
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
            if (ProcessName != null)
            {
                hash = hash * 59 + ProcessName.GetHashCode();
            }

            if (DelayMs != null)
            {
                hash = hash * 59 + DelayMs.GetHashCode();
            }

            if (MediaSubsystem != null)
            {
                hash = hash * 59 + MediaSubsystem.GetHashCode();
            }

            return hash;
        }
    }
}
