using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsSubsystem
/// </summary>
[DataContract]
public partial class EdgeMetricsSubsystem : IEquatable<EdgeMetricsSubsystem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsSubsystem" /> class.
    /// </summary>
    /// <param name="DelayMs">Delay in milliseconds..</param>
    /// <param name="ProcessName">Name of the Edge process..</param>
    /// <param name="MediaSubsystem">Subsystem for an Edge device..</param>
    public EdgeMetricsSubsystem(int? DelayMs = null, string ProcessName = null, EdgeMetricsSubsystem MediaSubsystem = null)
    {
        this.DelayMs = DelayMs;
        this.ProcessName = ProcessName;
        this.MediaSubsystem = MediaSubsystem;

    }



    /// <summary>
    /// Delay in milliseconds.
    /// </summary>
    /// <value>Delay in milliseconds.</value>
    [DataMember(Name = "delayMs", EmitDefaultValue = false)]
    public int? DelayMs { get; set; }



    /// <summary>
    /// Name of the Edge process.
    /// </summary>
    /// <value>Name of the Edge process.</value>
    [DataMember(Name = "processName", EmitDefaultValue = false)]
    public string ProcessName { get; set; }



    /// <summary>
    /// Subsystem for an Edge device.
    /// </summary>
    /// <value>Subsystem for an Edge device.</value>
    [DataMember(Name = "mediaSubsystem", EmitDefaultValue = false)]
    public EdgeMetricsSubsystem MediaSubsystem { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsSubsystem {\n");

        sb.Append("  DelayMs: ").Append(DelayMs).Append("\n");
        sb.Append("  ProcessName: ").Append(ProcessName).Append("\n");
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
        return Equals(obj as EdgeMetricsSubsystem);
    }

    /// <summary>
    /// Returns true if EdgeMetricsSubsystem instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsSubsystem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsSubsystem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DelayMs == other.DelayMs ||
                DelayMs != null &&
                DelayMs.Equals(other.DelayMs)
            ) &&
            (
                ProcessName == other.ProcessName ||
                ProcessName != null &&
                ProcessName.Equals(other.ProcessName)
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
            if (DelayMs != null)
            {
                hash = hash * 59 + DelayMs.GetHashCode();
            }

            if (ProcessName != null)
            {
                hash = hash * 59 + ProcessName.GetHashCode();
            }

            if (MediaSubsystem != null)
            {
                hash = hash * 59 + MediaSubsystem.GetHashCode();
            }

            return hash;
        }
    }
}
