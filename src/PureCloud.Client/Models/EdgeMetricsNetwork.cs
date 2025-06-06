using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsNetwork
/// </summary>

public partial class EdgeMetricsNetwork : IEquatable<EdgeMetricsNetwork>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsNetwork" /> class.
    /// </summary>
    /// <param name="Ifname">Identifier for the network adapter..</param>
    /// <param name="SentBytesPerSec">Number of byes sent per second..</param>
    /// <param name="ReceivedBytesPerSec">Number of byes received per second..</param>
    /// <param name="BandwidthBitsPerSec">Total bandwidth of the adapter in bits per second..</param>
    /// <param name="UtilizationPct">Percent utilization of the network adapter..</param>
    public EdgeMetricsNetwork(string Ifname = null, int? SentBytesPerSec = null, int? ReceivedBytesPerSec = null, double? BandwidthBitsPerSec = null, double? UtilizationPct = null)
    {
        this.Ifname = Ifname;
        this.SentBytesPerSec = SentBytesPerSec;
        this.ReceivedBytesPerSec = ReceivedBytesPerSec;
        this.BandwidthBitsPerSec = BandwidthBitsPerSec;
        this.UtilizationPct = UtilizationPct;

    }



    /// <summary>
    /// Identifier for the network adapter.
    /// </summary>
    /// <value>Identifier for the network adapter.</value>
    [JsonPropertyName("ifname")]
    public string Ifname { get; set; }



    /// <summary>
    /// Number of byes sent per second.
    /// </summary>
    /// <value>Number of byes sent per second.</value>
    [JsonPropertyName("sentBytesPerSec")]
    public int? SentBytesPerSec { get; set; }



    /// <summary>
    /// Number of byes received per second.
    /// </summary>
    /// <value>Number of byes received per second.</value>
    [JsonPropertyName("receivedBytesPerSec")]
    public int? ReceivedBytesPerSec { get; set; }



    /// <summary>
    /// Total bandwidth of the adapter in bits per second.
    /// </summary>
    /// <value>Total bandwidth of the adapter in bits per second.</value>
    [JsonPropertyName("bandwidthBitsPerSec")]
    public double? BandwidthBitsPerSec { get; set; }



    /// <summary>
    /// Percent utilization of the network adapter.
    /// </summary>
    /// <value>Percent utilization of the network adapter.</value>
    [JsonPropertyName("utilizationPct")]
    public double? UtilizationPct { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsNetwork {\n");

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
        return Equals(obj as EdgeMetricsNetwork);
    }

    /// <summary>
    /// Returns true if EdgeMetricsNetwork instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsNetwork to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsNetwork other)
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
