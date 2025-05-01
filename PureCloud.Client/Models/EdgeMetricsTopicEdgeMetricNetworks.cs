using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricNetworks
/// </summary>
[DataContract]
public partial class EdgeMetricsTopicEdgeMetricNetworks : IEquatable<EdgeMetricsTopicEdgeMetricNetworks>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricNetworks" /> class.
    /// </summary>
    /// <param name="Ifname">Ifname.</param>
    /// <param name="SentBytesPerSec">SentBytesPerSec.</param>
    /// <param name="ReceivedBytesPerSec">ReceivedBytesPerSec.</param>
    /// <param name="BandwidthBitsPerSec">BandwidthBitsPerSec.</param>
    /// <param name="UtilizationPct">UtilizationPct.</param>
    public EdgeMetricsTopicEdgeMetricNetworks(string Ifname = null, long? SentBytesPerSec = null, long? ReceivedBytesPerSec = null, long? BandwidthBitsPerSec = null, double? UtilizationPct = null)
    {
        this.Ifname = Ifname;
        this.SentBytesPerSec = SentBytesPerSec;
        this.ReceivedBytesPerSec = ReceivedBytesPerSec;
        this.BandwidthBitsPerSec = BandwidthBitsPerSec;
        this.UtilizationPct = UtilizationPct;

    }



    /// <summary>
    /// Gets or Sets Ifname
    /// </summary>
    [DataMember(Name = "ifname", EmitDefaultValue = false)]
    public string Ifname { get; set; }



    /// <summary>
    /// Gets or Sets SentBytesPerSec
    /// </summary>
    [DataMember(Name = "sentBytesPerSec", EmitDefaultValue = false)]
    public long? SentBytesPerSec { get; set; }



    /// <summary>
    /// Gets or Sets ReceivedBytesPerSec
    /// </summary>
    [DataMember(Name = "receivedBytesPerSec", EmitDefaultValue = false)]
    public long? ReceivedBytesPerSec { get; set; }



    /// <summary>
    /// Gets or Sets BandwidthBitsPerSec
    /// </summary>
    [DataMember(Name = "bandwidthBitsPerSec", EmitDefaultValue = false)]
    public long? BandwidthBitsPerSec { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationPct
    /// </summary>
    [DataMember(Name = "utilizationPct", EmitDefaultValue = false)]
    public double? UtilizationPct { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricNetworks {\n");

        sb.Append("  Ifname: ").Append(Ifname).Append("\n");
        sb.Append("  SentBytesPerSec: ").Append(SentBytesPerSec).Append("\n");
        sb.Append("  ReceivedBytesPerSec: ").Append(ReceivedBytesPerSec).Append("\n");
        sb.Append("  BandwidthBitsPerSec: ").Append(BandwidthBitsPerSec).Append("\n");
        sb.Append("  UtilizationPct: ").Append(UtilizationPct).Append("\n");
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
        return Equals(obj as EdgeMetricsTopicEdgeMetricNetworks);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricNetworks instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricNetworks to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricNetworks other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Ifname == other.Ifname ||
                Ifname != null &&
                Ifname.Equals(other.Ifname)
            ) &&
            (
                SentBytesPerSec == other.SentBytesPerSec ||
                SentBytesPerSec != null &&
                SentBytesPerSec.Equals(other.SentBytesPerSec)
            ) &&
            (
                ReceivedBytesPerSec == other.ReceivedBytesPerSec ||
                ReceivedBytesPerSec != null &&
                ReceivedBytesPerSec.Equals(other.ReceivedBytesPerSec)
            ) &&
            (
                BandwidthBitsPerSec == other.BandwidthBitsPerSec ||
                BandwidthBitsPerSec != null &&
                BandwidthBitsPerSec.Equals(other.BandwidthBitsPerSec)
            ) &&
            (
                UtilizationPct == other.UtilizationPct ||
                UtilizationPct != null &&
                UtilizationPct.Equals(other.UtilizationPct)
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
            if (Ifname != null)
            {
                hash = hash * 59 + Ifname.GetHashCode();
            }

            if (SentBytesPerSec != null)
            {
                hash = hash * 59 + SentBytesPerSec.GetHashCode();
            }

            if (ReceivedBytesPerSec != null)
            {
                hash = hash * 59 + ReceivedBytesPerSec.GetHashCode();
            }

            if (BandwidthBitsPerSec != null)
            {
                hash = hash * 59 + BandwidthBitsPerSec.GetHashCode();
            }

            if (UtilizationPct != null)
            {
                hash = hash * 59 + UtilizationPct.GetHashCode();
            }

            return hash;
        }
    }
}
