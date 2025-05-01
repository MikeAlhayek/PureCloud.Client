using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaRtpStatistics
/// </summary>
[DataContract]
public partial class MediaRtpStatistics : IEquatable<MediaRtpStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaRtpStatistics" /> class.
    /// </summary>
    /// <param name="PacketsReceived">Number of packets received, including all invalid, duplicate, and discarded packets.</param>
    /// <param name="PacketsSent">Number of packets sent.</param>
    /// <param name="RtpEventsReceived">Number of RFC#2833 packets received.</param>
    /// <param name="RtpEventsSent">Number of RFC#2833 packets sent.</param>
    /// <param name="EstimatedAverageMos">The estimated average MOS score.</param>
    public MediaRtpStatistics(int? PacketsReceived = null, int? PacketsSent = null, int? RtpEventsReceived = null, int? RtpEventsSent = null, double? EstimatedAverageMos = null)
    {
        this.PacketsReceived = PacketsReceived;
        this.PacketsSent = PacketsSent;
        this.RtpEventsReceived = RtpEventsReceived;
        this.RtpEventsSent = RtpEventsSent;
        this.EstimatedAverageMos = EstimatedAverageMos;

    }



    /// <summary>
    /// Number of packets received, including all invalid, duplicate, and discarded packets
    /// </summary>
    /// <value>Number of packets received, including all invalid, duplicate, and discarded packets</value>
    [DataMember(Name = "packetsReceived", EmitDefaultValue = false)]
    public int? PacketsReceived { get; set; }



    /// <summary>
    /// Number of packets sent
    /// </summary>
    /// <value>Number of packets sent</value>
    [DataMember(Name = "packetsSent", EmitDefaultValue = false)]
    public int? PacketsSent { get; set; }



    /// <summary>
    /// Number of RFC#2833 packets received
    /// </summary>
    /// <value>Number of RFC#2833 packets received</value>
    [DataMember(Name = "rtpEventsReceived", EmitDefaultValue = false)]
    public int? RtpEventsReceived { get; set; }



    /// <summary>
    /// Number of RFC#2833 packets sent
    /// </summary>
    /// <value>Number of RFC#2833 packets sent</value>
    [DataMember(Name = "rtpEventsSent", EmitDefaultValue = false)]
    public int? RtpEventsSent { get; set; }



    /// <summary>
    /// The estimated average MOS score
    /// </summary>
    /// <value>The estimated average MOS score</value>
    [DataMember(Name = "estimatedAverageMos", EmitDefaultValue = false)]
    public double? EstimatedAverageMos { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaRtpStatistics {\n");

        sb.Append("  PacketsReceived: ").Append(PacketsReceived).Append("\n");
        sb.Append("  PacketsSent: ").Append(PacketsSent).Append("\n");
        sb.Append("  RtpEventsReceived: ").Append(RtpEventsReceived).Append("\n");
        sb.Append("  RtpEventsSent: ").Append(RtpEventsSent).Append("\n");
        sb.Append("  EstimatedAverageMos: ").Append(EstimatedAverageMos).Append("\n");
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
        return Equals(obj as MediaRtpStatistics);
    }

    /// <summary>
    /// Returns true if MediaRtpStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaRtpStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaRtpStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PacketsReceived == other.PacketsReceived ||
                PacketsReceived != null &&
                PacketsReceived.Equals(other.PacketsReceived)
            ) &&
            (
                PacketsSent == other.PacketsSent ||
                PacketsSent != null &&
                PacketsSent.Equals(other.PacketsSent)
            ) &&
            (
                RtpEventsReceived == other.RtpEventsReceived ||
                RtpEventsReceived != null &&
                RtpEventsReceived.Equals(other.RtpEventsReceived)
            ) &&
            (
                RtpEventsSent == other.RtpEventsSent ||
                RtpEventsSent != null &&
                RtpEventsSent.Equals(other.RtpEventsSent)
            ) &&
            (
                EstimatedAverageMos == other.EstimatedAverageMos ||
                EstimatedAverageMos != null &&
                EstimatedAverageMos.Equals(other.EstimatedAverageMos)
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
            if (PacketsReceived != null)
            {
                hash = hash * 59 + PacketsReceived.GetHashCode();
            }

            if (PacketsSent != null)
            {
                hash = hash * 59 + PacketsSent.GetHashCode();
            }

            if (RtpEventsReceived != null)
            {
                hash = hash * 59 + RtpEventsReceived.GetHashCode();
            }

            if (RtpEventsSent != null)
            {
                hash = hash * 59 + RtpEventsSent.GetHashCode();
            }

            if (EstimatedAverageMos != null)
            {
                hash = hash * 59 + EstimatedAverageMos.GetHashCode();
            }

            return hash;
        }
    }
}
