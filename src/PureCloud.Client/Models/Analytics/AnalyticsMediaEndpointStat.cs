namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsMediaEndpointStat
{
    /// <summary>
    /// The MIME type(s) of the audio encodings used by the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The MIME type(s) of the audio encodings used by the audio streams belonging to this endpoint</value>
    public IEnumerable<string> Codecs { get; set; }

    /// <summary>
    /// The total number of packets received too late or too early, jitter queue overrun or underrun, for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of packets received too late or too early, jitter queue overrun or underrun, for all audio streams belonging to this endpoint</value>
    public long? DiscardedPackets { get; set; }

    /// <summary>
    /// The total number of packets received with the same sequence number as another one recently received (window of 64 packets), for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of packets received with the same sequence number as another one recently received (window of 64 packets), for all audio streams belonging to this endpoint</value>
    public long? DuplicatePackets { get; set; }

    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// The total number of malformed or not RTP packets, unknown payload type, or discarded probation packets for all audio streams belonging to this endpoint
    /// </summary>
    /// <value>The total number of malformed or not RTP packets, unknown payload type, or discarded probation packets for all audio streams belonging to this endpoint</value>
    public long? InvalidPackets { get; set; }

    /// <summary>
    /// The maximum latency experienced by any audio stream belonging to this endpoint, in milliseconds
    /// </summary>
    /// <value>The maximum latency experienced by any audio stream belonging to this endpoint, in milliseconds</value>
    public long? MaxLatencyMs { get; set; }

    /// <summary>
    /// The lowest estimated average MOS among all the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The lowest estimated average MOS among all the audio streams belonging to this endpoint</value>
    public double? MinMos { get; set; }

    /// <summary>
    /// The lowest R-factor value among all of the audio streams belonging to this endpoint
    /// </summary>
    /// <value>The lowest R-factor value among all of the audio streams belonging to this endpoint</value>
    public double? MinRFactor { get; set; }

    /// <summary>
    /// The total number of packets for which there was no room in the jitter queue when it was received, for all audio streams belonging to this endpoint (also counted in discarded)
    /// </summary>
    /// <value>The total number of packets for which there was no room in the jitter queue when it was received, for all audio streams belonging to this endpoint (also counted in discarded)</value>
    public long? OverrunPackets { get; set; }

    /// <summary>
    /// The total number of packets received for all audio streams belonging to this endpoint (includes invalid, duplicate, and discarded packets)
    /// </summary>
    /// <value>The total number of packets received for all audio streams belonging to this endpoint (includes invalid, duplicate, and discarded packets)</value>
    public long? ReceivedPackets { get; set; }

    /// <summary>
    /// The total number of packets received after their timestamp/seqnum has been played out, for all audio streams belonging to this endpoint (also counted in discarded)
    /// </summary>
    /// <value>The total number of packets received after their timestamp/seqnum has been played out, for all audio streams belonging to this endpoint (also counted in discarded)</value>
    public long? UnderrunPackets { get; set; }
}
