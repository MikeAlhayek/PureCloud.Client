using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetrics
/// </summary>

public partial class EdgeMetrics : IEquatable<EdgeMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetrics" /> class.
    /// </summary>
    /// <param name="Edge">Edge.</param>
    /// <param name="EventTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="UpTimeMsec">UpTimeMsec.</param>
    /// <param name="Processors">Processors.</param>
    /// <param name="Memory">Memory.</param>
    /// <param name="Disks">Disks.</param>
    /// <param name="Subsystems">Subsystems.</param>
    /// <param name="Networks">Networks.</param>
    public EdgeMetrics(DomainEntityRef Edge = null, DateTime? EventTime = null, long? UpTimeMsec = null, List<EdgeMetricsProcessor> Processors = null, List<EdgeMetricsMemory> Memory = null, List<EdgeMetricsDisk> Disks = null, List<EdgeMetricsSubsystem> Subsystems = null, List<EdgeMetricsNetwork> Networks = null)
    {
        this.Edge = Edge;
        this.EventTime = EventTime;
        this.UpTimeMsec = UpTimeMsec;
        this.Processors = Processors;
        this.Memory = Memory;
        this.Disks = Disks;
        this.Subsystems = Subsystems;
        this.Networks = Networks;

    }



    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    [JsonPropertyName("edge")]
    public DomainEntityRef Edge { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventTime")]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets UpTimeMsec
    /// </summary>
    [JsonPropertyName("upTimeMsec")]
    public long? UpTimeMsec { get; set; }



    /// <summary>
    /// Gets or Sets Processors
    /// </summary>
    [JsonPropertyName("processors")]
    public List<EdgeMetricsProcessor> Processors { get; set; }



    /// <summary>
    /// Gets or Sets Memory
    /// </summary>
    [JsonPropertyName("memory")]
    public List<EdgeMetricsMemory> Memory { get; set; }



    /// <summary>
    /// Gets or Sets Disks
    /// </summary>
    [JsonPropertyName("disks")]
    public List<EdgeMetricsDisk> Disks { get; set; }



    /// <summary>
    /// Gets or Sets Subsystems
    /// </summary>
    [JsonPropertyName("subsystems")]
    public List<EdgeMetricsSubsystem> Subsystems { get; set; }



    /// <summary>
    /// Gets or Sets Networks
    /// </summary>
    [JsonPropertyName("networks")]
    public List<EdgeMetricsNetwork> Networks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetrics {\n");

        sb.Append("  Edge: ").Append(Edge).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  UpTimeMsec: ").Append(UpTimeMsec).Append("\n");
        sb.Append("  Processors: ").Append(Processors).Append("\n");
        sb.Append("  Memory: ").Append(Memory).Append("\n");
        sb.Append("  Disks: ").Append(Disks).Append("\n");
        sb.Append("  Subsystems: ").Append(Subsystems).Append("\n");
        sb.Append("  Networks: ").Append(Networks).Append("\n");
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
        return Equals(obj as EdgeMetrics);
    }

    /// <summary>
    /// Returns true if EdgeMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Edge == other.Edge ||
                Edge != null &&
                Edge.Equals(other.Edge)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                UpTimeMsec == other.UpTimeMsec ||
                UpTimeMsec != null &&
                UpTimeMsec.Equals(other.UpTimeMsec)
            ) &&
            (
                Processors == other.Processors ||
                Processors != null &&
                Processors.SequenceEqual(other.Processors)
            ) &&
            (
                Memory == other.Memory ||
                Memory != null &&
                Memory.SequenceEqual(other.Memory)
            ) &&
            (
                Disks == other.Disks ||
                Disks != null &&
                Disks.SequenceEqual(other.Disks)
            ) &&
            (
                Subsystems == other.Subsystems ||
                Subsystems != null &&
                Subsystems.SequenceEqual(other.Subsystems)
            ) &&
            (
                Networks == other.Networks ||
                Networks != null &&
                Networks.SequenceEqual(other.Networks)
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
            if (Edge != null)
            {
                hash = hash * 59 + Edge.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (UpTimeMsec != null)
            {
                hash = hash * 59 + UpTimeMsec.GetHashCode();
            }

            if (Processors != null)
            {
                hash = hash * 59 + Processors.GetHashCode();
            }

            if (Memory != null)
            {
                hash = hash * 59 + Memory.GetHashCode();
            }

            if (Disks != null)
            {
                hash = hash * 59 + Disks.GetHashCode();
            }

            if (Subsystems != null)
            {
                hash = hash * 59 + Subsystems.GetHashCode();
            }

            if (Networks != null)
            {
                hash = hash * 59 + Networks.GetHashCode();
            }

            return hash;
        }
    }
}
