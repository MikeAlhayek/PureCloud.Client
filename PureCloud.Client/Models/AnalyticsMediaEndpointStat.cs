using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsMediaEndpointStat
/// </summary>
[DataContract]
public partial class AnalyticsMediaEndpointStat : IEquatable<AnalyticsMediaEndpointStat>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsMediaEndpointStat" /> class.
    /// </summary>
    /// <param name="Codecs">The MIME type(s) of the audio encodings used by the audio streams belonging to this endpoint.</param>
    /// <param name="DiscardedPackets">The total number of packets received too late or too early, jitter queue overrun or underrun, for all audio streams belonging to this endpoint.</param>
    /// <param name="DuplicatePackets">The total number of packets received with the same sequence number as another one recently received (window of 64 packets), for all audio streams belonging to this endpoint.</param>
    /// <param name="EventTime">Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="InvalidPackets">The total number of malformed or not RTP packets, unknown payload type, or discarded probation packets for all audio streams belonging to this endpoint.</param>
    /// <param name="MaxLatencyMs">The maximum latency experienced by any audio stream belonging to this endpoint, in milliseconds.</param>
    /// <param name="MinMos">The lowest estimated average MOS among all the audio streams belonging to this endpoint.</param>
    /// <param name="MinRFactor">The lowest R-factor value among all of the audio streams belonging to this endpoint.</param>
    /// <param name="OverrunPackets">The total number of packets for which there was no room in the jitter queue when it was received, for all audio streams belonging to this endpoint (also counted in discarded).</param>
    /// <param name="ReceivedPackets">The total number of packets received for all audio streams belonging to this endpoint (includes invalid, duplicate, and discarded packets).</param>
    /// <param name="UnderrunPackets">The total number of packets received after their timestamp/seqnum has been played out, for all audio streams belonging to this endpoint (also counted in discarded).</param>
    public AnalyticsMediaEndpointStat(List<string> Codecs = null, long? DiscardedPackets = null, long? DuplicatePackets = null, DateTime? EventTime = null, long? InvalidPackets = null, long? MaxLatencyMs = null, double? MinMos = null, double? MinRFactor = null, long? OverrunPackets = null, long? ReceivedPackets = null, long? UnderrunPackets = null)
    {
        this.Codecs = Codecs;
        this.DiscardedPackets = DiscardedPackets;
        this.DuplicatePackets = DuplicatePackets;
        this.EventTime = EventTime;
        this.InvalidPackets = InvalidPackets;
        this.MaxLatencyMs = MaxLatencyMs;
        this.MinMos = MinMos;
        this.MinRFactor = MinRFactor;
        this.OverrunPackets = OverrunPackets;
        this.ReceivedPackets = ReceivedPackets;
        this.UnderrunPackets = UnderrunPackets;

    }



    /// <summary>
    /// The MIME type(s) of the audio encodings used by the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The MIME type(s) of the audio encodings used by the audio streams belonging to this endpoint</value>
    [DataMember(Name = "codecs", EmitDefaultValue = false)]
    public List<string> Codecs { get; set; }



    /// <summary>
    /// The total number of packets received too late or too early, jitter queue overrun or underrun, for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of packets received too late or too early, jitter queue overrun or underrun, for all audio streams belonging to this endpoint</value>
    [DataMember(Name = "discardedPackets", EmitDefaultValue = false)]
    public long? DiscardedPackets { get; set; }



    /// <summary>
    /// The total number of packets received with the same sequence number as another one recently received (window of 64 packets), for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of packets received with the same sequence number as another one recently received (window of 64 packets), for all audio streams belonging to this endpoint</value>
    [DataMember(Name = "duplicatePackets", EmitDefaultValue = false)]
    public long? DuplicatePackets { get; set; }



    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// The total number of malformed or not RTP packets, unknown payload type, or discarded probation packets for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of malformed or not RTP packets, unknown payload type, or discarded probation packets for all audio streams belonging to this endpoint</value>
    [DataMember(Name = "invalidPackets", EmitDefaultValue = false)]
    public long? InvalidPackets { get; set; }



    /// <summary>
    /// The maximum latency experienced by any audio stream belonging to this endpoint, in milliseconds
    /// </summary>
    /// <value>The maximum latency experienced by any audio stream belonging to this endpoint, in milliseconds</value>
    [DataMember(Name = "maxLatencyMs", EmitDefaultValue = false)]
    public long? MaxLatencyMs { get; set; }



    /// <summary>
    /// The lowest estimated average MOS among all the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The lowest estimated average MOS among all the audio streams belonging to this endpoint</value>
    [DataMember(Name = "minMos", EmitDefaultValue = false)]
    public double? MinMos { get; set; }



    /// <summary>
    /// The lowest R-factor value among all of the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The lowest R-factor value among all of the audio streams belonging to this endpoint</value>
    [DataMember(Name = "minRFactor", EmitDefaultValue = false)]
    public double? MinRFactor { get; set; }



    /// <summary>
    /// The total number of packets for which there was no room in the jitter queue when it was received, for all audio streams belonging to this endpoint (also counted in discarded)
    /// </summary>
    /// <value>The total number of packets for which there was no room in the jitter queue when it was received, for all audio streams belonging to this endpoint (also counted in discarded)</value>
    [DataMember(Name = "overrunPackets", EmitDefaultValue = false)]
    public long? OverrunPackets { get; set; }



    /// <summary>
    /// The total number of packets received for all audio streams belonging to this endpoint (includes invalid, duplicate, and discarded packets)
    /// </summary>
    /// <value>The total number of packets received for all audio streams belonging to this endpoint (includes invalid, duplicate, and discarded packets)</value>
    [DataMember(Name = "receivedPackets", EmitDefaultValue = false)]
    public long? ReceivedPackets { get; set; }



    /// <summary>
    /// The total number of packets received after their timestamp/seqnum has been played out, for all audio streams belonging to this endpoint (also counted in discarded)
    /// </summary>
    /// <value>The total number of packets received after their timestamp/seqnum has been played out, for all audio streams belonging to this endpoint (also counted in discarded)</value>
    [DataMember(Name = "underrunPackets", EmitDefaultValue = false)]
    public long? UnderrunPackets { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsMediaEndpointStat {\n");

        sb.Append("  Codecs: ").Append(Codecs).Append("\n");
        sb.Append("  DiscardedPackets: ").Append(DiscardedPackets).Append("\n");
        sb.Append("  DuplicatePackets: ").Append(DuplicatePackets).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  InvalidPackets: ").Append(InvalidPackets).Append("\n");
        sb.Append("  MaxLatencyMs: ").Append(MaxLatencyMs).Append("\n");
        sb.Append("  MinMos: ").Append(MinMos).Append("\n");
        sb.Append("  MinRFactor: ").Append(MinRFactor).Append("\n");
        sb.Append("  OverrunPackets: ").Append(OverrunPackets).Append("\n");
        sb.Append("  ReceivedPackets: ").Append(ReceivedPackets).Append("\n");
        sb.Append("  UnderrunPackets: ").Append(UnderrunPackets).Append("\n");
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
        return Equals(obj as AnalyticsMediaEndpointStat);
    }

    /// <summary>
    /// Returns true if AnalyticsMediaEndpointStat instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsMediaEndpointStat to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsMediaEndpointStat other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Codecs == other.Codecs ||
                Codecs != null &&
                Codecs.SequenceEqual(other.Codecs)
            ) &&
            (
                DiscardedPackets == other.DiscardedPackets ||
                DiscardedPackets != null &&
                DiscardedPackets.Equals(other.DiscardedPackets)
            ) &&
            (
                DuplicatePackets == other.DuplicatePackets ||
                DuplicatePackets != null &&
                DuplicatePackets.Equals(other.DuplicatePackets)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                InvalidPackets == other.InvalidPackets ||
                InvalidPackets != null &&
                InvalidPackets.Equals(other.InvalidPackets)
            ) &&
            (
                MaxLatencyMs == other.MaxLatencyMs ||
                MaxLatencyMs != null &&
                MaxLatencyMs.Equals(other.MaxLatencyMs)
            ) &&
            (
                MinMos == other.MinMos ||
                MinMos != null &&
                MinMos.Equals(other.MinMos)
            ) &&
            (
                MinRFactor == other.MinRFactor ||
                MinRFactor != null &&
                MinRFactor.Equals(other.MinRFactor)
            ) &&
            (
                OverrunPackets == other.OverrunPackets ||
                OverrunPackets != null &&
                OverrunPackets.Equals(other.OverrunPackets)
            ) &&
            (
                ReceivedPackets == other.ReceivedPackets ||
                ReceivedPackets != null &&
                ReceivedPackets.Equals(other.ReceivedPackets)
            ) &&
            (
                UnderrunPackets == other.UnderrunPackets ||
                UnderrunPackets != null &&
                UnderrunPackets.Equals(other.UnderrunPackets)
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
            if (Codecs != null)
            {
                hash = hash * 59 + Codecs.GetHashCode();
            }

            if (DiscardedPackets != null)
            {
                hash = hash * 59 + DiscardedPackets.GetHashCode();
            }

            if (DuplicatePackets != null)
            {
                hash = hash * 59 + DuplicatePackets.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (InvalidPackets != null)
            {
                hash = hash * 59 + InvalidPackets.GetHashCode();
            }

            if (MaxLatencyMs != null)
            {
                hash = hash * 59 + MaxLatencyMs.GetHashCode();
            }

            if (MinMos != null)
            {
                hash = hash * 59 + MinMos.GetHashCode();
            }

            if (MinRFactor != null)
            {
                hash = hash * 59 + MinRFactor.GetHashCode();
            }

            if (OverrunPackets != null)
            {
                hash = hash * 59 + OverrunPackets.GetHashCode();
            }

            if (ReceivedPackets != null)
            {
                hash = hash * 59 + ReceivedPackets.GetHashCode();
            }

            if (UnderrunPackets != null)
            {
                hash = hash * 59 + UnderrunPackets.GetHashCode();
            }

            return hash;
        }
    }
}
