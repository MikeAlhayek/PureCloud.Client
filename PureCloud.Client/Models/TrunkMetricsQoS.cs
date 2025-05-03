using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetricsQoS
/// </summary>

public partial class TrunkMetricsQoS : IEquatable<TrunkMetricsQoS>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsQoS" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrunkMetricsQoS() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsQoS" /> class.
    /// </summary>
    /// <param name="MismatchCount">Total number of QoS mismatches over the course of the last 24-hour period (sliding window). (required).</param>
    public TrunkMetricsQoS(int? MismatchCount = null)
    {
        this.MismatchCount = MismatchCount;

    }



    /// <summary>
    /// Total number of QoS mismatches over the course of the last 24-hour period (sliding window).
    /// </summary>
    /// <value>Total number of QoS mismatches over the course of the last 24-hour period (sliding window).</value>
    [JsonPropertyName("mismatchCount")]
    public int? MismatchCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetricsQoS {\n");

        sb.Append("  MismatchCount: ").Append(MismatchCount).Append("\n");
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
        return Equals(obj as TrunkMetricsQoS);
    }

    /// <summary>
    /// Returns true if TrunkMetricsQoS instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetricsQoS to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetricsQoS other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MismatchCount == other.MismatchCount ||
                MismatchCount != null &&
                MismatchCount.Equals(other.MismatchCount)
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
            if (MismatchCount != null)
            {
                hash = hash * 59 + MismatchCount.GetHashCode();
            }

            return hash;
        }
    }
}
